using Terminal.Model;

namespace Terminal.Convertors
{
    public static class PacketTranslator
    {
        /* 
        here we make our packet   
        our packets are in the form of:

        //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        start bytes|packet length|datalogger serial number| packet tag             |command version|command code|data length      |data            |crc-16

          2 bytes  |   2 bytes   |         4 bytes        | 1 bytes                | 1 bytes       |    1 bytes |   2 bytes       |      n         |  2 bytes

        ( ABCD )   |( 15 + n )   |acording to the machine |( 0-255 outo increment )|(01-02-03-04)  |    30-A8   |based on commands|based on command|calculatable

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        current usage:  usage of the current day
        packet sent data field :     unique id | meter serial number 
                                       2 bytes |   4 bytes 

        packet received data field: unique id | serial number meter | daily usage | timeunix
                                     2 bytes  |  4 bytes            | 4 bytes     | 4 bytes

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        hourly usage:  usage of the current day in houres
        packet sent data field :     unique id | meter serial number| day of recent 62
                                       2 bytes |   4 bytes          |  1 byte
 
        packet received data field:  unique id | meter serial number| end of the day timeunix | hour 0 | ... | hour 23
                                       2 bytes |   4 bytes          |  4 bytes                | 2 bytes| ... | 2 bytes

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        daily usage:  usage of an especific day
        packet sent data field :     unique id | meter serial number| day of recent 62
                                       2 bytes |   4 bytes          |  1 byte

        packet received data field:  unique id | meter serial number| day usage x | timeunix x
                                       2 bytes | 4 bytes            | 4 bytes     | 4 bytes

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        monthly usage:  usage of an especific day
        packet sent data field :     unique id | meter serial number| day of recent 62
                                       2 bytes |   4 bytes          |  1 byte

        monthly usage:  total usage
        packet received data field:  unique id | meter serial number| day usage x | total usage  |  monthly usage |  timeunix 
                                       2 bytes | 4 bytes            | 4 bytes     | 4 bytes      |  4 bytes       |   4 bytes

        ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
         */
        public static dynamic Convertors(string packet)
        {
            if (packet[..4].Equals("ABCD", StringComparison.OrdinalIgnoreCase))
            {
                if (packet.Length == 30)
                {
                    // this packets contain no data information
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = "0000",
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 146)
                {
                    // this packets contain hourly usage information
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(27, 116),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 74)
                {
                    // this packets contain total usage information
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(26, 44),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 58)
                {
                    // this packets contain monthly usage information
                    // this packets contain current day usage data 
                    // this packets contain daily usage information
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(27, 28),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 48)
                {
                    // this packets contain alarm information
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(26, 18),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 64)
                {
                    // this packets contain midnight data for one meter information
                    // also data for month data with one meter
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(26, 34),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 96)
                {
                    // this packets contain midnight data for two meter information
                    // also data for month data with two meter
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(26, 66),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 128)
                {
                    // this packets contain midnight data for three meter information
                    // also data for month data with three meter
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(26, 98),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 160)
                {
                    // this packets contain midnight data for four meter information
                    // also data for month data with four meter
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(26, 130),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 192)
                {
                    // this packets contain midnight data for five meter information
                    // also data for month data with five meter
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(26, 162),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 224)
                {
                    // this packets contain midnight data for six meter information
                    // also data for month data with six meter
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(26, 194),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 288)
                {
                    // this packets contain midnight data for eight meter information
                    // also data for month data with eight meter
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(26, 258),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 144)
                {
                    // this packets contain hourly data for one meter information
                    // also data for hourly queue data with one meter
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(26, 114),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 256)
                {
                    // this packets contain hourly data for two meter information
                    // also data for hourly queue data with two meter
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(26, 226),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 368)
                {
                    // this packets contain hourly data for three meter information
                    // also data for hourly queue data with three meter
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(26, 338),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 480)
                {
                    // this packets contain hourly data for four meter information
                    // also data for hourly queue data with four meter
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(26, 450),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 592)
                {
                    // this packets contain hourly data for five meter information
                    // also data for hourly queue data with five meter
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(26, 562),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 704)
                {
                    // this packets contain hourly data for six meter information
                    // also data for hourly queue data with six meter
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(26, 674),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 816)
                {
                    // this packets contain hourly data for seven meter information
                    // also data for hourly queue data with seven meter
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(26, 784),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 928)
                {
                    // this packets contain hourly data for eight meter information
                    // also data for hourly queue data with eight meter
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(26, 898),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 66)
                {
                    // this packets contain queue data for one meter information=
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(26, 36),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 98)
                {
                    // this packets contain queue data for two meter information=
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(26, 68),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 130)
                {
                    // this packets contain queue data for three meter information=
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(26, 100),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 162)
                {
                    // this packets contain queue data for four meter information=
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(26, 132),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 194)
                {
                    // this packets contain queue data for five meter information=
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(26, 164),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 226)
                {
                    // this packets contain queue data for six meter information=
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(26, 196),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 258)
                {
                    // this packets contain queue data for seven meter information=
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(26, 228),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 290)
                {
                    // this packets contain queue data for eight meter information=
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(26, 260),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else if (packet.Length == 42)
                {
                    // this packets contain simcard balance data
                    var range = packet.Length;
                    Log log = new()
                    {
                        StartByte = "ABCD",
                        PacketLength = packet.Substring(4, 4),
                        DataLoggerSerialNumber = packet.Substring(8, 8),
                        PacketTag = packet.Substring(16, 2),
                        CommandVersion = packet.Substring(18, 2),
                        CommandCode = packet.Substring(20, 2),
                        DataLength = packet.Substring(22, 4),
                        Data = packet.Substring(26, 12),
                        Crc = packet.Substring(range - 4, 4),
                        Date = "",
                    };
                    return log;
                }
                else
                {
                    return "پکت تعریف نشده";
                }
            }
            else
            {
                return "پکت تعریف نشده";
            }
        }
        }
}
