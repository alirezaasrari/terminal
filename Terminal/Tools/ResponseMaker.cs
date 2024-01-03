using System.Net.Sockets;
using System.Text;
using Terminal.Convertors;

namespace Terminal.Tools
{
    public static class ResponseMaker
    {
        public static byte[] ResponseGenerator(string message, TcpClient senderClient)
        {
            var TranslatedMessage = PacketTranslator.Convertors(message);
            bool IsPacketValid;
            byte[] responseBuffer;
            // here we check if the received packet is in the category or not?
            if (Equals(TranslatedMessage, "پکت تعریف نشده"))
            {
                // if the received packet is not defined and out of the category we must answer back it by nothing!!!
                responseBuffer = Encoding.UTF8.GetBytes("");
                return responseBuffer;
            }
            else
            {
                // now after validating the received packet we must check if we must answer it back or not?
                IsPacketValid = true;
                var serialnumber = message.Substring(8, 8);
                var tag = message.Substring(16, 2);
                var version = message.Substring(18, 2);
                var code = CompareCrc.YesOrNo(message, TranslatedMessage.Crc) == "yes" ? 30 : 31;
                var SendResponseCondition = ("A5").Equals(message.Substring(20, 2), StringComparison.OrdinalIgnoreCase);
                if (IsPacketValid && SendResponseCondition == false)
                {
                    // here we see if the received packet must be answered by data ok or crc error
                    if (code == 30)
                    {
                        responseBuffer = Encoding.UTF8.GetBytes($"ABCD000F" +
                        $"{serialnumber}{tag}{version}{code}0000" +
                        $"{CrcCalculator.CalculateChecksum($"{serialnumber}{tag}{version}{code}0000")}");
                        senderClient.GetStream().Write(responseBuffer, 0, responseBuffer.Length);
                        return responseBuffer;
                    }
                    else
                    {
                        // if the received packet crc is invalid we send the report back
                        responseBuffer = Encoding.UTF8.GetBytes($"ABCD000F" +
                        $"{serialnumber}{tag}{version}{code}0000" +
                        $"{CrcCalculator.CalculateChecksum($"{serialnumber}{tag}{version}310000")}");
                        senderClient.GetStream().Write(responseBuffer, 0, responseBuffer.Length);
                        return responseBuffer;
                    }
                }
                else if (IsPacketValid && SendResponseCondition == true)
                {
                    // here we check the crc of the received packet validation and send our requests
                    if (code == 30)
                    {
                        // here we receive the command or setting from the user or admin for the datalogger and its meters
                        Console.WriteLine("please enter your command for the datalogger such as settings or fota or ...");
                        string? respons = Console.ReadLine();
                        if (respons != null && respons.Length > 0)
                        {
                            // if the admin used the TUI for answering back we pass it to the datalogger 
                            responseBuffer = Encoding.UTF8.GetBytes(respons);
                            senderClient.GetStream().Write(responseBuffer, 0, responseBuffer.Length);
                            return responseBuffer;
                        }
                        else
                        {
                            // if console.readline returned null we pass empty string to the datalogger
                            responseBuffer = Encoding.UTF8.GetBytes("");
                            senderClient.GetStream().Write(responseBuffer, 0, responseBuffer.Length);
                            return responseBuffer;
                        }
                    }
                    else
                    {
                        // if the received packet crc is invalid we send the report back
                        responseBuffer = Encoding.UTF8.GetBytes($"ABCD000F" +
                        $"{serialnumber}{tag}{version}{code}0000" +
                        $"{CrcCalculator.CalculateChecksum($"{serialnumber}{tag}{version}310000")}");
                        senderClient.GetStream().Write(responseBuffer, 0, responseBuffer.Length);
                        return responseBuffer;
                    }
                }
                else
                {
                    // otherwise we will answer the received packet here by nothing!!!
                    responseBuffer = Encoding.UTF8.GetBytes("");
                    senderClient.GetStream().Write(responseBuffer, 0, responseBuffer.Length);
                    return responseBuffer;
                }
            }
        }
    }
}
