namespace Terminal.Convertors
{
    public static class CompareCrc
    {
        public static string YesOrNo(string packet, string crc)
        {
            if (packet.Length == 30 || packet.Length == 146 || packet.Length == 74 || packet.Length == 58 || packet.Length == 48
                || packet.Length == 64 || packet.Length == 96 || packet.Length == 128 || packet.Length == 160
                || packet.Length == 192 || packet.Length == 224 || packet.Length == 256 || packet.Length == 288
                || packet.Length == 144 || packet.Length == 256 || packet.Length == 368
                || packet.Length == 480 || packet.Length == 592 || packet.Length == 704 || packet.Length == 816
                || packet.Length == 928 || packet.Length == 66 || packet.Length == 98
                || packet.Length == 130 || packet.Length == 162 || packet.Length == 194
                || packet.Length == 226 || packet.Length == 258 || packet.Length == 290
                )
            {
                if (packet.Length == 30)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 18));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 146)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 134));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 74)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 62));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 58)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 46));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 48)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 36));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 64)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 52));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 96)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 84));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 128)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 116));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 160)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 148));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 192)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 180));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 224)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 212));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 256)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 244));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 288)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 276));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 144)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 132));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 256)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 244));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 368)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 356));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 480)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 468));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 592)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 580));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 704)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 692));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 816)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 804));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 928)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 916));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 66)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 54));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 98)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 86));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 130)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 118));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 162)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 150));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 194)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 182));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 226)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 214));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 258)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 246));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else if (packet.Length == 290)
                {
                    var CalculatedCrc = CrcCalculator.CalculateChecksum(packet.Substring(8, 278));
                    return CalculatedCrc.Equals(crc, StringComparison.OrdinalIgnoreCase) ? "yes" : "no";
                }
                else
                {
                    return "تعریف نشده";                
                }
            }
            else
            {
                return "no";
            }
        }
    }
}
