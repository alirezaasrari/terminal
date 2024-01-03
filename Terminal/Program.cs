using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Terminal;
using Terminal.Context;
using Terminal.Convertors;
using Terminal.Dictionaries;
using Terminal.Model;
using Terminal.Tools;

class ChatServer
{
    // we defien our properties for the chatserve class 
    // a listener for receiving stream from the tcp clients
    private readonly TcpListener listener;

    // a dictionary for saving the received clients endpoints
    private readonly Dictionary<string, TcpClient> clientMap = new();
    public ChatServer(string host, int port)
    {
        // listener is getting newed for the ip and port
        listener = new TcpListener(IPAddress.Parse(host), port);
        
        // the listener start working
        listener.Start();

        // a prompt on the console show which ip and port is being used for listenning
        Console.WriteLine("Chat server started on " + host + ":" + port);
    }
    public void Run()
    {
        while (true)
        {
            // our tcp listener starts accepting the client
            TcpClient client = listener.AcceptTcpClient();

            // the client stream is saving as the strem as networkstream object
            NetworkStream stream = client.GetStream();

            ThreadPool.QueueUserWorkItem(state => HandleClient(client, clientMap));
        }
    }
    private static void HandleClient(TcpClient client, Dictionary<string, TcpClient> clientMap)
    {
        // now we save the accepted client ip and port
        var track = client.Client.RemoteEndPoint;

        // in these series of code we create a communication with the database and its provider to use in future
        var services = new ServiceCollection();

        // this is the connection string for communication with the database
        var connectionString = "server=62.106.95.104;port=3306;database=talayieh;user=root;password=1372328$oheiL!@#$!;";

        // in this part we prepare for using entity framework core context as a connectin bridge with the table and models
        services.AddDbContext<DataContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
        var serviceProvider = services.BuildServiceProvider();
        using var scope = serviceProvider.CreateScope();
        var db = scope.ServiceProvider.GetService<DataContext>();

        while (true)
        {
            //here we start getting the stream from our client that we have accepted that
            NetworkStream stream = client.GetStream();

            try
            {
                // here we define a buffer for saving the received packet in that
                byte[] buffer = new byte[1024];

                // here we charge our buffer with the stream received to us and fill that array of bytes
                int bytesRead = stream.Read(buffer, 0, buffer.Length);

                // if the connection with the client end we break the connection
                if (bytesRead == 0)
                {
                    client.Close();
                    break;
                }
                
                string? senderIpAddressAndPort = client?.Client?.RemoteEndPoint?.ToString();
                // we add the client that is sending us the packet to the list
                if (senderIpAddressAndPort != null && !clientMap.ContainsKey(senderIpAddressAndPort))
                {
                    clientMap.Add(senderIpAddressAndPort, client);
                }
                // here we get the string equivalence of the received buffer from the client
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);

                // in this section we translate the received packet and split it to its parts
                var TranslatedMessage = PacketTranslator.Convertors(message);
                
                // if we have such a client we define a tcp client for that to use for answering
                TcpClient senderClient = clientMap[senderIpAddressAndPort];

                byte[]  responseBuffer = ResponseMaker.ResponseGenerator(message, senderClient);
                // just for a visulaized result on the console we use this log         
                Console.WriteLine("Client message: " + message + "and the packet translator will do the rest for you ...");
                
                try
                {
                    string DataLoggerSerialInDecimalForCheck = HexToDecimalConvertor.HexToDecimal(TranslatedMessage.DataLoggerSerialNumber).ToString();
                    var isdataloggervalid = SerialNumberCheck.SerialCheck(DataLoggerSerialInDecimalForCheck);
                    // here we get ready for fully translating the received packet for saving on the database
                    var Log = new Log()
                    {
                        StartByte = TranslatedMessage.StartByte,
                        PacketTag = TranslatedMessage.PacketTag,
                        DataLoggerSerialNumber = TranslatedMessage.DataLoggerSerialNumber,
                        DataLength = TranslatedMessage.DataLength,
                        Data = TranslatedMessage.Data,
                        Crc = TranslatedMessage.Crc,
                        CommandVersion = TranslatedMessage.CommandVersion,
                        CommandCode = TranslatedMessage.CommandCode,
                        PacketLength = TranslatedMessage.PacketLength,
                        Date = TimeCalculator.ConvertMiladiToshamsi(),
                        CommandCodeMeaning = CommandManager.GetCommandDescription(TranslatedMessage.CommandCode),
                        CommandVersionMeaning = CommandManager.GetCommandDescription(TranslatedMessage.CommandVersion),
                        DataContent = PacketDataAnalizer.DataAnalizer(TranslatedMessage.Data, TranslatedMessage.CommandCode),
                        DataLoggerSerialInDecimal = HexToDecimalConvertor.HexToDecimal(TranslatedMessage.DataLoggerSerialNumber),
                        IpAndPort = track != null ? track.ToString() : "بدون ip and port!!!",
                        IsCrcValid = CompareCrc.YesOrNo(message, TranslatedMessage.Crc),
                        Response = responseBuffer,
                        IsDataLoggerValid = isdataloggervalid
                    };

                    db?.NewTerminal.Add(Log);
                    db?.SaveChanges();
                }
                catch (Exception ex)
                {
                    // certainly execptions will be moderated here
                    var ineerexception = ex.InnerException;
                    if (ineerexception != null)
                    {
                        var error = new Error()
                        {
                            Message = ex.Message,
                            Date = TimeCalculator.ConvertMiladiToshamsi(),
                            WrongPacket = message,
                            Endpoint = track != null ? track.ToString() : "بدون ip and port!!!",
                        };
                        db?.NewTerminalError.Add(error);
                        db?.SaveChanges();
                    }
                    else
                    {
                        var error = new Error()
                        {
                            Message = "خطای تعریف نشده",
                            Date = TimeCalculator.ConvertMiladiToshamsi(),
                            WrongPacket = message,
                            Endpoint = senderIpAddressAndPort
                        };
                        db?.NewTerminalError.Add(error);
                        db?.SaveChanges();
                    };
                }

            }
            catch (SocketException ex)
            {
                var ineerexception = ex.InnerException;
                if (ineerexception != null)
                {
                    var error = new SocketErrors()
                    {
                        Message = ineerexception.ToString()[..255],
                        Date = TimeCalculator.ConvertMiladiToshamsi(),
                    };
                    db?.NewTerminalSocketError.Add(error);
                    db?.SaveChanges();
                    client.Close();
                    break;
                }
                else
                {
                    var error = new SocketErrors()
                    {
                        Message = "an unhandelled exception",
                        Date = TimeCalculator.ConvertMiladiToshamsi(),
                    };
                    db?.NewTerminalSocketError.Add(error);
                    db?.SaveChanges();
                };
            }
            catch (IOException ex)
            {
                var ineerexception = ex.InnerException;
                if (ineerexception != null)
                {
                    var error = new IoError()
                    {
                        Message = ineerexception.ToString(),
                        Date = TimeCalculator.ConvertMiladiToshamsi(),
                    };
                    db?.NewTerminalIoError.Add(error);
                    db?.SaveChanges();
                    client.Close();
                    break;
                }
                else
                {
                    var error = new IoError()
                    {
                        Message = "خطای تعریف نشده",
                        Date = TimeCalculator.ConvertMiladiToshamsi(),
                    };
                    db?.NewTerminalIoError.Add(error);
                    db?.SaveChanges();
                };
            }
        }
    }
    public static void Main(string[] args)
    {
        string host = "195.88.208.36";
        //string host = "127.0.0.1";
        int port = 8000;
        //int port = 80;

        if (args.Length > 0)
        {
            host = args[0];
        }

        if (args.Length > 1)
        {
            port = int.Parse(args[1]);
        }

        ChatServer server = new(host, port);
        server.Run();
        // Sends a FIN segment to the
        // other end of the TCP connection, indicating that the
        // sender has no more data to send.
        // The stream remains open for receiving data. 
        // we use:
        // stream.Shutdown(SocketShutdown.Send)

        //Sends a FIN segment to the other end of the
        //TCP connection, indicating that the sender has no
        //more data to send. The stream is then closed and
        //all resources associated with the stream are released.
        // we use: 
        // stream.Close()
        /*
         * this code can be added to the client constructor to automatically
         client.NoDelay = true;
        client.ReceiveTimeout = 3000;  3 seconds in milliseconds 
         */
    }
}
