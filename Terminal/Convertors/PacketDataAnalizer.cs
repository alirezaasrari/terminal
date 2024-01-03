using Terminal.Dictionaries;

namespace Terminal.Convertors
{
    public static class PacketDataAnalizer
    {
        public static string DataAnalizer(string data, string Code)
        {
            if (data == null)
            {
                return "بدون اطلاعات";
            }
            else
            {
                if (data.Length == 28 && Code == "40")
                {
                    // this is the data for current usage and one meter
                    return $"شناسه یکتا:{HexToDecimalConvertor.HexToDecimal(data[..4])}," +
                        $" شماره سریال کنتور:{HexToDecimalConvertor.HexToDecimal(data.Substring(4, 8))} ," +
                        $" مصرف فعلی:{HexToDecimalConvertor.HexToDecimal(data.Substring(12, 8)) / 10} لیتر," +
                        $" زمان تخلیه اطلاعات:{HexDateConverter.ConvertHexToDate(data.Substring(20, 8))} ,";
                }
                else if (data.Length == 116 && Code == "41")
                {
                    // this is the data for horly usage and one meter
                    return $"شناسه یکتا:{HexToDecimalConvertor.HexToDecimal(data[..4])}," +
                        $" شماره سریال کنتور:{HexToDecimalConvertor.HexToDecimal(data.Substring(4, 8))}, " +
                        $"زمان تخلیه اطلاعات در پایان روز:{HexDateConverter.ConvertHexToDate(data.Substring(12, 8))}," +
                        $" مصرف ساعت اول:{HexToDecimalConvertor.HexToDecimal(data.Substring(20, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(24, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(28, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(32, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(36, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(40, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(44, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(48, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم:{HexToDecimalConvertor.HexToDecimal(data.Substring(52, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم:{HexToDecimalConvertor.HexToDecimal(data.Substring(56, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم:{HexToDecimalConvertor.HexToDecimal(data.Substring(60, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم:{HexToDecimalConvertor.HexToDecimal(data.Substring(64, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم:{HexToDecimalConvertor.HexToDecimal(data.Substring(68, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم:{HexToDecimalConvertor.HexToDecimal(data.Substring(72, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم:{HexToDecimalConvertor.HexToDecimal(data.Substring(76, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم:{HexToDecimalConvertor.HexToDecimal(data.Substring(80, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم:{HexToDecimalConvertor.HexToDecimal(data.Substring(84, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم:{HexToDecimalConvertor.HexToDecimal(data.Substring(88, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم:{HexToDecimalConvertor.HexToDecimal(data.Substring(92, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم:{HexToDecimalConvertor.HexToDecimal(data.Substring(96, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم:{HexToDecimalConvertor.HexToDecimal(data.Substring(100, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(104, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(108, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(112, 4)) / 10} لیتر,";
                }
                else if (data.Length == 28 && Code == "42")
                {
                    // this is the data for daily usage and one meter
                    return $"شناسه یکتا:{HexToDecimalConvertor.HexToDecimal(data[..4])}," +
                        $" شناسه کنتور:{HexToDecimalConvertor.HexToDecimal(data.Substring(4, 8))} ," +
                        $" مصرف روزانه:{HexToDecimalConvertor.HexToDecimal(data.Substring(12, 8)) / 10}  لیتر," +
                        $" زمان تخلیه اطلاعات:{HexDateConverter.ConvertHexToDate(data.Substring(20, 8))}  ,";
                }
                else if (data.Length == 28 && Code == "43")
                {
                    // this is the data for mounth and one meter
                    return $"شناسه یکتا:{HexToDecimalConvertor.HexToDecimal(data[..4])} ," +
                        $" شناسه کنتور:{HexToDecimalConvertor.HexToDecimal(data.Substring(4, 8))} ," +
                        $" مصرف ماهانه:{HexToDecimalConvertor.HexToDecimal(data.Substring(12, 8)) / 10} لیتر," +
                        $" زمان تخلیه اطلاعات:{HexDateConverter.ConvertHexToDate(data.Substring(20, 8))} ,";
                }
                else if (data.Length == 44 && Code == "44")
                {
                    // this is the data for total usage and one meter
                    return $"شناسه یکتا:{HexToDecimalConvertor.HexToDecimal(data[..4])} ," +
                        $" سریال کنتور:{HexToDecimalConvertor.HexToDecimal(data.Substring(4, 8))} ," +
                        $"مصرف کل:{HexToDecimalConvertor.HexToDecimal(data.Substring(12, 8)) / 10} لیتر," +
                        $" مصرف ماهانه:{HexToDecimalConvertor.HexToDecimal(data.Substring(21, 8)) / 10} لیتر," +
                        $" مصرف روزانه:{HexToDecimalConvertor.HexToDecimal(data.Substring(29, 8)) / 10}  لیتر," +
                        $" زمان تخلیه اطلاعات:{HexDateConverter.ConvertHexToDate(data.Substring(37, 8))}";
                }
                else if (data.Length == 18 && Code == "A6" || Code == "a6")
                {
                    // this is the data for alarm of one meter
                    return $"سریال کنتور:{HexToDecimalConvertor.HexToDecimal(data[..8])} ," +
                        $" زمان تخلیه اطلاعات:{HexDateConverter.ConvertHexToDate(data.Substring(8, 8))} ," +
                        $" خطا:{CommandManager.GetCommandDescription(data.Substring(16, 2))} ,";
                }
                else if (data.Length == 12)
                {
                    // this is the data for simcard balance
                    return $"شناسه یکتا:{HexToDecimalConvertor.HexToDecimal(data[..4])} ," +
                        $"شارژ سیمکارت به ریال:{HexToDecimalConvertor.HexToDecimal(data.Substring(4, 8))} ,";
                }
                else if (data.Length == 34 && Code == "A0" || Code == "a0")
                {
                    // this is the data for midnight and one meter 
                    return $"تعداد کنتورها:{HexToDecimalConvertor.HexToDecimal(data[..2])} ," +
                        $"شماره سریال کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(2, 8))} ," +
                        $"مصرف کل کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(10, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(18, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور اول :{HexDateConverter.ConvertHexToDate(data.Substring(26, 8))} ,";
                }
                else if (data.Length == 66 && Code == "A0" || Code == "a0")
                {
                    // this the data for midnight and two meter 
                    return $"تعداد کنتورها:{HexToDecimalConvertor.HexToDecimal(data[..2])} ," +
                        $"شماره سریال کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(2, 8))} ," +
                        $"مصرف کل کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(10, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(18, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور اول :{HexDateConverter.ConvertHexToDate(data.Substring(26, 8))} ," +
                        $"شماره سریال کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(34, 8))} ," +
                        $"مصرف کل کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(42, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(50, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور دوم :{HexDateConverter.ConvertHexToDate(data.Substring(58, 8))} ,";
                }
                else if (data.Length == 98 && Code == "A0" || Code == "a0")
                {
                    // this is the data for midnight and three meter
                    return $"تعداد کنتورها:{HexToDecimalConvertor.HexToDecimal(data[..2])} ," +
                        $"شماره سریال کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(2, 8))} ," +
                        $"مصرف کل کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(10, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(18, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور اول :{HexDateConverter.ConvertHexToDate(data.Substring(26, 8))} ," +
                        $"شماره سریال کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(34, 8))} ," +
                        $"مصرف کل کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(42, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(50, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور دوم :{HexDateConverter.ConvertHexToDate(data.Substring(58, 8))} ," +
                        $"شماره سریال کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(66, 8))} ," +
                        $"مصرف کل کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(74, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(80, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور سوم :{HexDateConverter.ConvertHexToDate(data.Substring(88, 8))} ,";
                }
                else if (data.Length == 130 && Code == "A0" || Code == "a0")
                {
                    // this is the data for midnight and four meter
                    return $"تعداد کنتورها:{HexToDecimalConvertor.HexToDecimal(data[..2])} ," +
                        $"شماره سریال کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(2, 8))} ," +
                        $"مصرف کل کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(10, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(18, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور اول :{HexDateConverter.ConvertHexToDate(data.Substring(26, 8))} ," +
                        $"شماره سریال کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(34, 8))} ," +
                        $"مصرف کل کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(42, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(50, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور دوم :{HexDateConverter.ConvertHexToDate(data.Substring(58, 8))} ," +
                        $"شماره سریال کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(66, 8))} ," +
                        $"مصرف کل کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(74, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(82, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور سوم :{HexDateConverter.ConvertHexToDate(data.Substring(90, 8))} ," +
                        $"شماره سریال کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(98, 8))} ," +
                        $"مصرف کل کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(106, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(114, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور چهارم :{HexDateConverter.ConvertHexToDate(data.Substring(122, 8))} ,";
                }
                else if (data.Length == 162 && Code == "A0" || Code == "a0")
                {
                    // this is the data for midnight and five meter
                    return $"تعداد کنتورها:{HexToDecimalConvertor.HexToDecimal(data[..2])} ," +
                        $"شماره سریال کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(2, 8))} ," +
                        $"مصرف کل کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(10, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(18, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور اول :{HexDateConverter.ConvertHexToDate(data.Substring(26, 8))} ," +
                        $"شماره سریال کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(34, 8))} ," +
                        $"مصرف کل کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(42, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(50, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور دوم :{HexDateConverter.ConvertHexToDate(data.Substring(58, 8))} ," +
                        $"شماره سریال کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(66, 8))} ," +
                        $"مصرف کل کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(74, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(82, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور سوم :{HexDateConverter.ConvertHexToDate(data.Substring(90, 8))} ," +
                        $"شماره سریال کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(98, 8))} ," +
                        $"مصرف کل کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(106, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(114, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور چهارم :{HexDateConverter.ConvertHexToDate(data.Substring(122, 8))} ," +
                        $"شماره سریال کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(130, 8))} ," +
                        $"مصرف کل کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(138, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(146, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور پنجم :{HexDateConverter.ConvertHexToDate(data.Substring(154, 8))} ,";
                }
                else if (data.Length == 194 && Code == "A0" || Code == "a0")
                {
                    // this is the data for midnight and six meter
                    return $"تعداد کنتورها:{HexToDecimalConvertor.HexToDecimal(data[..2])} ," +
                        $"شماره سریال کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(2, 8))} ," +
                        $"مصرف کل کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(10, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(18, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور اول :{HexDateConverter.ConvertHexToDate(data.Substring(26, 8))} ," +
                        $"شماره سریال کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(34, 8))} ," +
                        $"مصرف کل کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(42, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(50, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور دوم :{HexDateConverter.ConvertHexToDate(data.Substring(58, 8))} ," +
                        $"شماره سریال کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(66, 8))} ," +
                        $"مصرف کل کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(74, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(82, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور سوم :{HexDateConverter.ConvertHexToDate(data.Substring(90, 8))} ," +
                        $"شماره سریال کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(98, 8))} ," +
                        $"مصرف کل کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(106, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(114, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور چهارم :{HexDateConverter.ConvertHexToDate(data.Substring(122, 8))} ," +
                        $"شماره سریال کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(130, 8))} ," +
                        $"مصرف کل کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(138, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(146, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور پنجم :{HexDateConverter.ConvertHexToDate(data.Substring(154, 8))} ," +
                        $"شماره سریال کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(162, 8))} ," +
                        $"مصرف کل کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(170, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(178, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور ششم :{HexDateConverter.ConvertHexToDate(data.Substring(186, 8))} ,";
                }
                else if (data.Length == 226 && Code == "A0" || Code == "a0")
                {
                    // this is the data for midnight and seven meter
                    return $"تعداد کنتورها:{HexToDecimalConvertor.HexToDecimal(data[..2])} ," +
                        $"شماره سریال کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(2, 8))} ," +
                        $"مصرف کل کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(10, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(18, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور اول :{HexDateConverter.ConvertHexToDate(data.Substring(26, 8))} ," +
                        $"شماره سریال کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(34, 8))} ," +
                        $"مصرف کل کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(42, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(50, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور دوم :{HexDateConverter.ConvertHexToDate(data.Substring(58, 8))} ," +
                        $"شماره سریال کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(66, 8))} ," +
                        $"مصرف کل کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(74, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(82, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور سوم :{HexDateConverter.ConvertHexToDate(data.Substring(90, 8))} ," +
                        $"شماره سریال کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(98, 8))} ," +
                        $"مصرف کل کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(106, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(114, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور چهارم :{HexDateConverter.ConvertHexToDate(data.Substring(122, 8))} ," +
                        $"شماره سریال کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(130, 8))} ," +
                        $"مصرف کل کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(138, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(146, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور پنجم :{HexDateConverter.ConvertHexToDate(data.Substring(154, 8))} ," +
                        $"شماره سریال کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(162, 8))} ," +
                        $"مصرف کل کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(170, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(178, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور ششم :{HexDateConverter.ConvertHexToDate(data.Substring(186, 8))} ," +
                        $"شماره سریال کنتور هفتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(194, 8))} ," +
                        $"مصرف کل کنتور هفتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(202, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور هفتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(210, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور هفتم :{HexDateConverter.ConvertHexToDate(data.Substring(218, 8))} ,";
                }
                else if (data.Length == 258 && Code == "A0" || Code == "a0")
                {
                    // this is the data for midnight and eight meter
                    return $"تعداد کنتورها:{HexToDecimalConvertor.HexToDecimal(data[..2])} ," +
                        $"شماره سریال کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(2, 8))} ," +
                        $"مصرف کل کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(10, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(18, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور اول :{HexDateConverter.ConvertHexToDate(data.Substring(26, 8))} ," +
                        $"شماره سریال کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(34, 8))} ," +
                        $"مصرف کل کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(42, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(50, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور دوم :{HexDateConverter.ConvertHexToDate(data.Substring(58, 8))} ," +
                        $"شماره سریال کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(66, 8))} ," +
                        $"مصرف کل کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(74, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(82, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور سوم :{HexDateConverter.ConvertHexToDate(data.Substring(90, 8))} ," +
                        $"شماره سریال کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(98, 8))} ," +
                        $"مصرف کل کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(106, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(114, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور چهارم :{HexDateConverter.ConvertHexToDate(data.Substring(122, 8))} ," +
                        $"شماره سریال کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(130, 8))} ," +
                        $"مصرف کل کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(138, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(146, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور پنجم :{HexDateConverter.ConvertHexToDate(data.Substring(154, 8))} ," +
                        $"شماره سریال کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(162, 8))} ," +
                        $"مصرف کل کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(170, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(178, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور ششم :{HexDateConverter.ConvertHexToDate(data.Substring(186, 8))} ," +
                        $"شماره سریال کنتور هفتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(194, 8))} ," +
                        $"مصرف کل کنتور هفتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(202, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور هفتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(210, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور هفتم :{HexDateConverter.ConvertHexToDate(data.Substring(218, 8))} ," +
                        $"شماره سریال کنتور هشتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(226, 8))} ," +
                        $"مصرف کل کنتور هشتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(234, 8)) / 10} لیتر ," +
                        $"مصرف روزانه کنتور هشتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(242, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور هشتم :{HexDateConverter.ConvertHexToDate(data.Substring(250, 8))} ,";
                }
                else if (data.Length == 34 && Code == "A2" || Code == "a2")
                {
                    // this is the data for month and one meter 
                    return $"تعداد کنتورها:{HexToDecimalConvertor.HexToDecimal(data[..2])} ," +
                        $"شماره سریال کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(2, 8))} ," +
                        $"مصرف کل کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(10, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(18, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور اول :{HexDateConverter.ConvertHexToDate(data.Substring(26, 8))} ,";
                }
                else if (data.Length == 66 && Code == "A2" || Code == "a2")
                {
                    // this the data for month and two meter 
                    return $"تعداد کنتورها:{HexToDecimalConvertor.HexToDecimal(data[..2])} ," +
                        $"شماره سریال کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(2, 8))} ," +
                        $"مصرف کل کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(10, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(18, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور اول :{HexDateConverter.ConvertHexToDate(data.Substring(26, 8))} ," +
                        $"شماره سریال کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(34, 8))} ," +
                        $"مصرف کل کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(42, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(50, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور دوم :{HexDateConverter.ConvertHexToDate(data.Substring(58, 8))} ,";
                }
                else if (data.Length == 98 && Code == "A2" || Code == "a2")
                {
                    // this is the data for month and three meter
                    return $"تعداد کنتورها:{HexToDecimalConvertor.HexToDecimal(data[..2])} ," +
                        $"شماره سریال کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(2, 8))} ," +
                        $"مصرف کل کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(10, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(18, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور اول :{HexDateConverter.ConvertHexToDate(data.Substring(26, 8))} ," +
                        $"شماره سریال کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(34, 8))} ," +
                        $"مصرف کل کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(42, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(50, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور دوم :{HexDateConverter.ConvertHexToDate(data.Substring(58, 8))} ," +
                        $"شماره سریال کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(66, 8))} ," +
                        $"مصرف کل کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(74, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(80, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور سوم :{HexDateConverter.ConvertHexToDate(data.Substring(88, 8))} ,";
                }
                else if (data.Length == 130 && Code == "A2" || Code == "a2")
                {
                    // this is the data for month and four meter
                    return $"تعداد کنتورها:{HexToDecimalConvertor.HexToDecimal(data[..2])} ," +
                        $"شماره سریال کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(2, 8))} ," +
                        $"مصرف کل کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(10, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(18, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور اول :{HexDateConverter.ConvertHexToDate(data.Substring(26, 8))} ," +
                        $"شماره سریال کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(34, 8))} ," +
                        $"مصرف کل کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(42, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(50, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور دوم :{HexDateConverter.ConvertHexToDate(data.Substring(58, 8))} ," +
                        $"شماره سریال کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(66, 8))} ," +
                        $"مصرف کل کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(74, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(82, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور سوم :{HexDateConverter.ConvertHexToDate(data.Substring(90, 8))} ," +
                        $"شماره سریال کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(98, 8))} ," +
                        $"مصرف کل کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(106, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(114, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور چهارم :{HexDateConverter.ConvertHexToDate(data.Substring(122, 8))} ,";
                }
                else if (data.Length == 162 && Code == "A2" || Code == "a2")
                {
                    // this is the data for month and five meter
                    return $"تعداد کنتورها:{HexToDecimalConvertor.HexToDecimal(data[..2])} ," +
                        $"شماره سریال کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(2, 8))} ," +
                        $"مصرف کل کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(10, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(18, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور اول :{HexDateConverter.ConvertHexToDate(data.Substring(26, 8))} ," +
                        $"شماره سریال کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(34, 8))} ," +
                        $"مصرف کل کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(42, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(50, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور دوم :{HexDateConverter.ConvertHexToDate(data.Substring(58, 8))} ," +
                        $"شماره سریال کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(66, 8))} ," +
                        $"مصرف کل کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(74, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(82, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور سوم :{HexDateConverter.ConvertHexToDate(data.Substring(90, 8))} ," +
                        $"شماره سریال کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(98, 8))} ," +
                        $"مصرف کل کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(106, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(114, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور چهارم :{HexDateConverter.ConvertHexToDate(data.Substring(122, 8))} ," +
                        $"شماره سریال کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(130, 8))} ," +
                        $"مصرف کل کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(138, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(146, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور پنجم :{HexDateConverter.ConvertHexToDate(data.Substring(154, 8))} ,";
                }
                else if (data.Length == 194 && Code == "A2" || Code == "a2")
                {
                    // this is the data for month and six meter
                    return $"تعداد کنتورها:{HexToDecimalConvertor.HexToDecimal(data[..2])} ," +
                        $"شماره سریال کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(2, 8))} ," +
                        $"مصرف کل کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(10, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(18, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور اول :{HexDateConverter.ConvertHexToDate(data.Substring(26, 8))} ," +
                        $"شماره سریال کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(34, 8))} ," +
                        $"مصرف کل کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(42, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(50, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور دوم :{HexDateConverter.ConvertHexToDate(data.Substring(58, 8))} ," +
                        $"شماره سریال کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(66, 8))} ," +
                        $"مصرف کل کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(74, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(82, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور سوم :{HexDateConverter.ConvertHexToDate(data.Substring(90, 8))} ," +
                        $"شماره سریال کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(98, 8))} ," +
                        $"مصرف کل کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(106, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(114, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور چهارم :{HexDateConverter.ConvertHexToDate(data.Substring(122, 8))} ," +
                        $"شماره سریال کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(130, 8))} ," +
                        $"مصرف کل کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(138, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(146, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور پنجم :{HexDateConverter.ConvertHexToDate(data.Substring(154, 8))} ," +
                        $"شماره سریال کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(162, 8))} ," +
                        $"مصرف کل کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(170, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(178, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور ششم :{HexDateConverter.ConvertHexToDate(data.Substring(186, 8))} ,";
                }
                else if (data.Length == 226 && Code == "A2" || Code == "a2")
                {
                    // this is the data for month and seven meter
                    return $"تعداد کنتورها:{HexToDecimalConvertor.HexToDecimal(data[..2])} ," +
                        $"شماره سریال کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(2, 8))} ," +
                        $"مصرف کل کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(10, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(18, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور اول :{HexDateConverter.ConvertHexToDate(data.Substring(26, 8))} ," +
                        $"شماره سریال کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(34, 8))} ," +
                        $"مصرف کل کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(42, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(50, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور دوم :{HexDateConverter.ConvertHexToDate(data.Substring(58, 8))} ," +
                        $"شماره سریال کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(66, 8))} ," +
                        $"مصرف کل کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(74, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(82, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور سوم :{HexDateConverter.ConvertHexToDate(data.Substring(90, 8))} ," +
                        $"شماره سریال کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(98, 8))} ," +
                        $"مصرف کل کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(106, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(114, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور چهارم :{HexDateConverter.ConvertHexToDate(data.Substring(122, 8))} ," +
                        $"شماره سریال کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(130, 8))} ," +
                        $"مصرف کل کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(138, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(146, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور پنجم :{HexDateConverter.ConvertHexToDate(data.Substring(154, 8))} ," +
                        $"شماره سریال کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(162, 8))} ," +
                        $"مصرف کل کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(170, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(178, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور ششم :{HexDateConverter.ConvertHexToDate(data.Substring(186, 8))} ," +
                        $"شماره سریال کنتور هفتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(194, 8))} ," +
                        $"مصرف کل کنتور هفتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(202, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور هفتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(210, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور هفتم :{HexDateConverter.ConvertHexToDate(data.Substring(218, 8))} ,";
                }
                else if (data.Length == 258 && Code == "A2" || Code == "a2")
                {
                    // this is the data for month and eight meter
                    return $"تعداد کنتورها:{HexToDecimalConvertor.HexToDecimal(data[..2])} ," +
                        $"شماره سریال کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(2, 8))} ," +
                        $"مصرف کل کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(10, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(18, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور اول :{HexDateConverter.ConvertHexToDate(data.Substring(26, 8))} ," +
                        $"شماره سریال کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(34, 8))} ," +
                        $"مصرف کل کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(42, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(50, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور دوم :{HexDateConverter.ConvertHexToDate(data.Substring(58, 8))} ," +
                        $"شماره سریال کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(66, 8))} ," +
                        $"مصرف کل کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(74, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(82, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور سوم :{HexDateConverter.ConvertHexToDate(data.Substring(90, 8))} ," +
                        $"شماره سریال کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(98, 8))} ," +
                        $"مصرف کل کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(106, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(114, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور چهارم :{HexDateConverter.ConvertHexToDate(data.Substring(122, 8))} ," +
                        $"شماره سریال کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(130, 8))} ," +
                        $"مصرف کل کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(138, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(146, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور پنجم :{HexDateConverter.ConvertHexToDate(data.Substring(154, 8))} ," +
                        $"شماره سریال کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(162, 8))} ," +
                        $"مصرف کل کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(170, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(178, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور ششم :{HexDateConverter.ConvertHexToDate(data.Substring(186, 8))} ," +
                        $"شماره سریال کنتور هفتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(194, 8))} ," +
                        $"مصرف کل کنتور هفتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(202, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور هفتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(210, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور هفتم :{HexDateConverter.ConvertHexToDate(data.Substring(218, 8))} ," +
                        $"شماره سریال کنتور هشتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(226, 8))} ," +
                        $"مصرف کل کنتور هشتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(234, 8)) / 10} لیتر ," +
                        $"مصرف ماهانه کنتور هشتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(242, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور هشتم :{HexDateConverter.ConvertHexToDate(data.Substring(250, 8))} ,";
                }
                else if (data.Length == 114 && Code == "a1" || Code == "A1" || Code == "A4" || Code == "a4")
                {
                    // this is the data for hourly usage and one meter
                    // also this state can describe queue data for hourly profile of one meter
                    return $"تعداد کنتور ها:{HexToDecimalConvertor.HexToDecimal(data[..2])}," +
                        $" شماره سریال کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(2, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتوراول:{HexDateConverter.ConvertHexToDate(data.Substring(10, 8))}," +
                        $" مصرف ساعت اول کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(18, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(22, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(26, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(30, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(34, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(38, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(42, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(46, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(50, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(54, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(58, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(62, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(66, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(70, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(74, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(78, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(82, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(86, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(90, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(94, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(98, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(102, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(106, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(110, 4)) / 10} لیتر,";
                }
                else if (data.Length == 226 && Code == "a1" || Code == "A1" || Code == "A4" || Code == "a4")
                {
                    // this is the data for hourly usage and two meter
                    // also this state can describe queue data for hourly profile of two meter
                    return $"تعداد کنتور ها:{HexToDecimalConvertor.HexToDecimal(data[..2])}," +
                        $" شماره سریال کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(2, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتوراول:{HexDateConverter.ConvertHexToDate(data.Substring(10, 8))}," +
                        $" مصرف ساعت اول کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(18, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(22, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(26, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(30, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(34, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(38, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(42, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(46, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(50, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(54, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(58, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(62, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(66, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(70, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(74, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(78, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(82, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(86, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(90, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(94, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(98, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(102, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(106, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(110, 4)) / 10} لیتر," +
                        $" شماره سریال کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(114, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتوردوم:{HexDateConverter.ConvertHexToDate(data.Substring(122, 8))}," +
                        $" مصرف ساعت اول کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(130, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(134, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(138, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(142, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(146, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(150, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(154, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(158, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(162, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(166, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(170, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(174, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(178, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(182, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(186, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(190, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(194, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(198, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(202, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(206, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(210, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(214, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(218, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(222, 4)) / 10} لیتر,";
                }
                else if (data.Length == 338 && Code == "a1" || Code == "A1" || Code == "A4" || Code == "a4")
                {
                    // this is the data for hourly usage and three meter
                    // also this state can describe queue data for hourly profile of three meter
                    return $"تعداد کنتور ها:{HexToDecimalConvertor.HexToDecimal(data[..2])}," +
                        $" شماره سریال کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(2, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتوراول:{HexDateConverter.ConvertHexToDate(data.Substring(10, 8))}," +
                        $" مصرف ساعت اول کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(18, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(22, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(26, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(30, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(34, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(38, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(42, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(46, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(50, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(54, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(58, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(62, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(66, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(70, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(74, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(78, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(82, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(86, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(90, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(94, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(98, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(102, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(106, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(110, 4)) / 10} لیتر," +
                        $" شماره سریال کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(114, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتوردوم:{HexDateConverter.ConvertHexToDate(data.Substring(122, 8))}," +
                        $" مصرف ساعت اول کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(130, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(134, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(138, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(142, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(146, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(150, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(154, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(158, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(162, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(166, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(170, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(174, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(178, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(182, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(186, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(190, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(194, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(198, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(202, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(206, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(210, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(214, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(218, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(222, 4)) / 10} لیتر," +
                        $" شماره سریال کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(226, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتورسوم:{HexDateConverter.ConvertHexToDate(data.Substring(234, 8))}," +
                        $" مصرف ساعت اول کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(242, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(246, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(250, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(254, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(258, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(262, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(266, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(270, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(274, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(278, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(282, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(286, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(290, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(294, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(298, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(302, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(306, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(310, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(314, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(318, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(322, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(326, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(330, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(334, 4)) / 10} لیتر,";
                }
                else if (data.Length == 450 && Code == "a1" || Code == "A1" || Code == "A4" || Code == "a4")
                {
                    // this is the data for hourly usage and four meter
                    // also this state can describe queue data for hourly profile of four meter
                    return $"تعداد کنتور ها:{HexToDecimalConvertor.HexToDecimal(data[..2])}," +
                        $" شماره سریال کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(2, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتوراول:{HexDateConverter.ConvertHexToDate(data.Substring(10, 8))}," +
                        $" مصرف ساعت اول کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(18, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(22, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(26, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(30, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(34, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(38, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(42, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(46, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(50, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(54, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(58, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(62, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(66, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(70, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(74, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(78, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(82, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(86, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(90, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(94, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(98, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(102, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(106, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(110, 4)) / 10} لیتر," +
                        $" شماره سریال کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(114, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتوردوم:{HexDateConverter.ConvertHexToDate(data.Substring(122, 8))}," +
                        $" مصرف ساعت اول کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(130, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(134, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(138, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(142, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(146, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(150, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(154, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(158, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(162, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(166, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(170, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(174, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(178, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(182, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(186, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(190, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(194, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(198, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(202, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(206, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(210, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(214, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(218, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(222, 4)) / 10} لیتر," +
                        $" شماره سریال کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(226, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتورسوم:{HexDateConverter.ConvertHexToDate(data.Substring(234, 8))}," +
                        $" مصرف ساعت اول کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(242, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(246, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(250, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(254, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(258, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(262, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(266, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(270, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(274, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(278, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(282, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(286, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(290, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(294, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(298, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(302, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(306, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(310, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(314, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(318, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(322, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(326, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(330, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(334, 4)) / 10} لیتر," +
                        $" شماره سریال کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(338, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتورچهارم:{HexDateConverter.ConvertHexToDate(data.Substring(346, 8))}," +
                        $" مصرف ساعت اول کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(354, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(358, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(362, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(366, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(370, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(374, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(378, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(382, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(386, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(390, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(394, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(398, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(402, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(406, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(410, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(414, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(418, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(422, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(426, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(430, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(434, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(438, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(442, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(446, 4)) / 10} لیتر,";
                }
                else if (data.Length == 562 && Code == "a1" || Code == "A1" || Code == "A4" || Code == "a4")
                {
                    // this is the data for hourly usage and five meter
                    // also this state can describe queue data for hourly profile of five meter
                    return $"تعداد کنتور ها:{HexToDecimalConvertor.HexToDecimal(data[..2])}," +
                        $" شماره سریال کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(2, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتوراول:{HexDateConverter.ConvertHexToDate(data.Substring(10, 8))}," +
                        $" مصرف ساعت اول کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(18, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(22, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(26, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(30, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(34, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(38, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(42, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(46, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(50, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(54, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(58, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(62, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(66, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(70, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(74, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(78, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(82, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(86, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(90, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(94, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(98, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(102, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(106, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(110, 4)) / 10} لیتر," +
                        $" شماره سریال کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(114, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتوردوم:{HexDateConverter.ConvertHexToDate(data.Substring(122, 8))}," +
                        $" مصرف ساعت اول کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(130, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(134, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(138, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(142, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(146, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(150, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(154, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(158, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(162, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(166, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(170, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(174, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(178, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(182, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(186, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(190, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(194, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(198, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(202, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(206, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(210, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(214, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(218, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(222, 4)) / 10} لیتر," +
                        $" شماره سریال کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(226, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتورسوم:{HexDateConverter.ConvertHexToDate(data.Substring(234, 8))}," +
                        $" مصرف ساعت اول کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(242, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(246, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(250, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(254, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(258, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(262, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(266, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(270, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(274, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(278, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(282, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(286, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(290, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(294, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(298, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(302, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(306, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(310, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(314, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(318, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(322, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(326, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(330, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(334, 4)) / 10} لیتر," +
                        $" شماره سریال کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(338, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتورچهارم:{HexDateConverter.ConvertHexToDate(data.Substring(346, 8))}," +
                        $" مصرف ساعت اول کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(354, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(358, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(362, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(366, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(370, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(374, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(378, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(382, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(386, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(390, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(394, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(398, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(402, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(406, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(410, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(414, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(418, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(422, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(426, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(430, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(434, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(438, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(442, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(446, 4)) / 10} لیتر," +
                        $" شماره سریال کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(450, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتورپنجم:{HexDateConverter.ConvertHexToDate(data.Substring(458, 8))}," +
                        $" مصرف ساعت اول کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(466, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(470, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(474, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(478, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(482, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(486, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(490, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(494, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(498, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(502, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(506, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(510, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(514, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(518, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(522, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(526, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(530, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(534, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(538, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(542, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(546, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(550, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(554, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(558, 4)) / 10} لیتر,";
                }
                else if (data.Length == 674 && Code == "a1" || Code == "A1" || Code == "A4" || Code == "a4")
                {
                    // this is the data for hourly usage and six meter
                    // also this state can describe queue data for hourly profile of six meter
                    return $"تعداد کنتور ها:{HexToDecimalConvertor.HexToDecimal(data[..2])}," +
                        $" شماره سریال کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(2, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتوراول:{HexDateConverter.ConvertHexToDate(data.Substring(10, 8))}," +
                        $" مصرف ساعت اول کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(18, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(22, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(26, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(30, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(34, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(38, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(42, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(46, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(50, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(54, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(58, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(62, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(66, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(70, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(74, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(78, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(82, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(86, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(90, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(94, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(98, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(102, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(106, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(110, 4)) / 10} لیتر," +
                        $" شماره سریال کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(114, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتوردوم:{HexDateConverter.ConvertHexToDate(data.Substring(122, 8))}," +
                        $" مصرف ساعت اول کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(130, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(134, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(138, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(142, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(146, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(150, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(154, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(158, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(162, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(166, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(170, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(174, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(178, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(182, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(186, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(190, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(194, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(198, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(202, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(206, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(210, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(214, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(218, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(222, 4)) / 10} لیتر," +
                        $" شماره سریال کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(226, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتورسوم:{HexDateConverter.ConvertHexToDate(data.Substring(234, 8))}," +
                        $" مصرف ساعت اول کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(242, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(246, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(250, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(254, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(258, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(262, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(266, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(270, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(274, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(278, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(282, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(286, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(290, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(294, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(298, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(302, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(306, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(310, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(314, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(318, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(322, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(326, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(330, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(334, 4)) / 10} لیتر," +
                        $" شماره سریال کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(338, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتورچهارم:{HexDateConverter.ConvertHexToDate(data.Substring(346, 8))}," +
                        $" مصرف ساعت اول کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(354, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(358, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(362, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(366, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(370, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(374, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(378, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(382, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(386, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(390, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(394, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(398, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(402, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(406, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(410, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(414, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(418, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(422, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(426, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(430, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(434, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(438, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(442, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(446, 4)) / 10} لیتر," +
                        $" شماره سریال کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(450, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتورپنجم:{HexDateConverter.ConvertHexToDate(data.Substring(458, 8))}," +
                        $" مصرف ساعت اول کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(466, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(470, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(474, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(478, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(482, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(486, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(490, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(494, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(498, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(502, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(506, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(510, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(514, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(518, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(522, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(526, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(530, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(534, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(538, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(542, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(546, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(550, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(554, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(558, 4)) / 10} لیتر," +
                        $" شماره سریال کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(562, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتورششم:{HexDateConverter.ConvertHexToDate(data.Substring(570, 8))}," +
                        $" مصرف ساعت اول کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(578, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(482, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(586, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(590, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(594, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(598, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(602, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(606, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(610, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(614, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(618, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(622, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(626, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(630, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(634, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(638, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(642, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(646, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(650, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(654, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(658, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(662, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(666, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(670, 4)) / 10} لیتر,";
                }
                else if (data.Length == 786 && Code == "a1" || Code == "A1" || Code == "A4" || Code == "a4")
                {
                    // this is the data for hourly usage and seven meter
                    // also this state can describe queue data for hourly profile of seven meter
                    return $"تعداد کنتور ها:{HexToDecimalConvertor.HexToDecimal(data[..2])}," +
                        $" شماره سریال کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(2, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتوراول:{HexDateConverter.ConvertHexToDate(data.Substring(10, 8))}," +
                        $" مصرف ساعت اول کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(18, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(22, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(26, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(30, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(34, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(38, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(42, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(46, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(50, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(54, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(58, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(62, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(66, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(70, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(74, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(78, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(82, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(86, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(90, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(94, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(98, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(102, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(106, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(110, 4)) / 10} لیتر," +
                        $" شماره سریال کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(114, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتوردوم:{HexDateConverter.ConvertHexToDate(data.Substring(122, 8))}," +
                        $" مصرف ساعت اول کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(130, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(134, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(138, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(142, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(146, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(150, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(154, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(158, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(162, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(166, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(170, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(174, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(178, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(182, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(186, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(190, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(194, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(198, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(202, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(206, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(210, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(214, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(218, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(222, 4)) / 10} لیتر," +
                        $" شماره سریال کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(226, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتورسوم:{HexDateConverter.ConvertHexToDate(data.Substring(234, 8))}," +
                        $" مصرف ساعت اول کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(242, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(246, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(250, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(254, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(258, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(262, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(266, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(270, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(274, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(278, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(282, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(286, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(290, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(294, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(298, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(302, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(306, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(310, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(314, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(318, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(322, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(326, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(330, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(334, 4)) / 10} لیتر," +
                        $" شماره سریال کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(338, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتورچهارم:{HexDateConverter.ConvertHexToDate(data.Substring(346, 8))}," +
                        $" مصرف ساعت اول کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(354, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(358, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(362, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(366, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(370, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(374, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(378, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(382, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(386, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(390, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(394, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(398, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(402, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(406, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(410, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(414, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(418, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(422, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(426, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(430, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(434, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(438, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(442, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(446, 4)) / 10} لیتر," +
                        $" شماره سریال کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(450, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتورپنجم:{HexDateConverter.ConvertHexToDate(data.Substring(458, 8))}," +
                        $" مصرف ساعت اول کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(466, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(470, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(474, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(478, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(482, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(486, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(490, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(494, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(498, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(502, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(506, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(510, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(514, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(518, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(522, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(526, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(530, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(534, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(538, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(542, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(546, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(550, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(554, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(558, 4)) / 10} لیتر," +
                        $" شماره سریال کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(562, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتورششم:{HexDateConverter.ConvertHexToDate(data.Substring(570, 8))}," +
                        $" مصرف ساعت اول کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(578, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(582, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(586, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(590, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(594, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(598, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(602, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(606, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(610, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(614, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(618, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(622, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(626, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(630, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(634, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(638, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(642, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(646, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(650, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(654, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(658, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(662, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(666, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(670, 4)) / 10} لیتر," +
                        $" شماره سریال کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(674, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتورهفتم:{HexDateConverter.ConvertHexToDate(data.Substring(682, 8))}," +
                        $" مصرف ساعت اول کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(690, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(694, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(698, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(702, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(706, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(710, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(714, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(718, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(722, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(726, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(730, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(734, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(738, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(742, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(746, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(750, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(754, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(758, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(762, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(766, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(770, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(774, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(778, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(782, 4)) / 10} لیتر,";
                }
                else if (data.Length == 898 && Code == "a1" || Code == "A1" || Code == "A4" || Code == "a4")
                {
                    // this is the data for hourly usage and eight meter
                    // also this state can describe queue data for hourly profile of eight meter
                    return $"تعداد کنتور ها:{HexToDecimalConvertor.HexToDecimal(data[..2])}," +
                        $" شماره سریال کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(2, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتوراول:{HexDateConverter.ConvertHexToDate(data.Substring(10, 8))}," +
                        $" مصرف ساعت اول کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(18, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(22, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(26, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(30, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(34, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(38, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(42, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(46, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(50, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(54, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(58, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(62, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(66, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(70, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(74, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(78, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(82, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(86, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(90, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(94, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(98, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(102, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(106, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتوراول:{HexToDecimalConvertor.HexToDecimal(data.Substring(110, 4)) / 10} لیتر," +
                        $" شماره سریال کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(114, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتوردوم:{HexDateConverter.ConvertHexToDate(data.Substring(122, 8))}," +
                        $" مصرف ساعت اول کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(130, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(134, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(138, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(142, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(146, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(150, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(154, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(158, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(162, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(166, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(170, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(174, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(178, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(182, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(186, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(190, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(194, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(198, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(202, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(206, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(210, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(214, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(218, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتوردوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(222, 4)) / 10} لیتر," +
                        $" شماره سریال کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(226, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتورسوم:{HexDateConverter.ConvertHexToDate(data.Substring(234, 8))}," +
                        $" مصرف ساعت اول کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(242, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(246, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(250, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(254, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(258, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(262, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(266, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(270, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(274, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(278, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(282, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(286, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(290, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(294, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(298, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(302, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(306, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(310, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(314, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(318, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(322, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(326, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(330, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتورسوم:{HexToDecimalConvertor.HexToDecimal(data.Substring(334, 4)) / 10} لیتر," +
                        $" شماره سریال کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(338, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتورچهارم:{HexDateConverter.ConvertHexToDate(data.Substring(346, 8))}," +
                        $" مصرف ساعت اول کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(354, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(358, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(362, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(366, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(370, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(374, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(378, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(382, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(386, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(390, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(394, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(398, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(402, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(406, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(410, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(414, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(418, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(422, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(426, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(430, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(434, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(438, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(442, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتورچهارم:{HexToDecimalConvertor.HexToDecimal(data.Substring(446, 4)) / 10} لیتر," +
                        $" شماره سریال کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(450, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتورپنجم:{HexDateConverter.ConvertHexToDate(data.Substring(458, 8))}," +
                        $" مصرف ساعت اول کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(466, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(470, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(474, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(478, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(482, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(486, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(490, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(494, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(498, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(502, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(506, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(510, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(514, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(518, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(522, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(526, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(530, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(534, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(538, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(542, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(546, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(550, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(554, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتورپنجم:{HexToDecimalConvertor.HexToDecimal(data.Substring(558, 4)) / 10} لیتر," +
                        $" شماره سریال کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(562, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتورششم:{HexDateConverter.ConvertHexToDate(data.Substring(570, 8))}," +
                        $" مصرف ساعت اول کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(578, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(582, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(586, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(590, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(594, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(598, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(602, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(606, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(610, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(614, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(618, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(622, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(626, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(630, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(634, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(638, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(642, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(646, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(650, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(654, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(658, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(662, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(666, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتورششم:{HexToDecimalConvertor.HexToDecimal(data.Substring(670, 4)) / 10} لیتر," +
                        $" شماره سریال کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(674, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتورهفتم:{HexDateConverter.ConvertHexToDate(data.Substring(682, 8))}," +
                        $" مصرف ساعت اول کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(690, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(694, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(698, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(702, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(706, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(710, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(714, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(718, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(722, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(726, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(730, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(734, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(738, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(742, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(746, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(750, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(754, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(758, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(762, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(766, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(770, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(774, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(778, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتورهفتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(782, 4)) / 10} لیتر," +
                        $" شماره سریال کنتورهشتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(786, 8))}, " +
                        $" زمان تخلیه اطلاعات در پایان روز کنتورهشتم:{HexDateConverter.ConvertHexToDate(data.Substring(794, 8))}," +
                        $" مصرف ساعت اول کنتورهشتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(802, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوم کنتورهشتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(806, 4)) / 10} لیتر," +
                        $" مصرف ساعت سوم کنتورهشتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(810, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهارم کنتورهشتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(814, 4)) / 10} لیتر," +
                        $" مصرف ساعت پنجم کنتورهشتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(818, 4)) / 10} لیتر," +
                        $" مصرف ساعت ششم کنتورهشتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(822, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفتم کنتورهشتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(826, 4)) / 10} لیتر," +
                        $" مصرف ساعت هشتم کنتورهشتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(830, 4)) / 10} لیتر," +
                        $" مصرف ساعت نهم کنتورهشتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(834, 4)) / 10} لیتر," +
                        $" مصرف ساعت دهم کنتورهشتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(838, 4)) / 10} لیتر," +
                        $" مصرف ساعت یازدهم کنتورهشتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(842, 4)) / 10} لیتر," +
                        $" مصرف ساعت دوازدهم کنتورهشتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(846, 4)) / 10} لیتر," +
                        $" مصرف ساعت سیزدهم کنتورهشتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(850, 4)) / 10} لیتر," +
                        $" مصرف ساعت چهاردهم کنتورهشتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(854, 4)) / 10} لیتر," +
                        $" مصرف ساعت پانزدهم کنتورهشتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(858, 4)) / 10} لیتر," +
                        $" مصرف ساعت شانزدهم کنتورهشتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(862, 4)) / 10} لیتر," +
                        $" مصرف ساعت هفدهم کنتورهشتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(866, 4)) / 10} لیتر," +
                        $" مصرف ساعت هجدهم کنتورهشتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(870, 4)) / 10} لیتر," +
                        $" مصرف ساعت نوزدهم کنتورهشتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(874, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیستم کنتورهشتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(878, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و یکم کنتورهشتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(882, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و دوم کنتورهشتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(886, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و سوم کنتورهشتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(890, 4)) / 10} لیتر," +
                        $" مصرف ساعت بیست و چهارم کنتورهشتم:{HexToDecimalConvertor.HexToDecimal(data.Substring(894, 4)) / 10} لیتر,";
                }
                else if (data.Length == 36 && Code == "A3" || Code == "a3")
                {
                    // this is the data for queue and one meter 
                    string firstTwoDigits = data[..2];
                    bool isMonthly = firstTwoDigits == "00";
                    string frequency = isMonthly ? "ماهانه" : "روزانه";
                    return $"{frequency} " +
                        $"تعداد کنتورها : {HexToDecimalConvertor.HexToDecimal(data.Substring(2,2))} ," +
                        $"شماره سریال کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(4, 8))} ," +
                        $"مصرف کل کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(12, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(20, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور اول :{HexDateConverter.ConvertHexToDate(data.Substring(28, 8))} ,";
                }
                else if (data.Length == 68 && Code == "A3" || Code == "a3")
                {
                    // this the data for queue and two meter 
                    string firstTwoDigits = data[..2];
                    bool isMonthly = firstTwoDigits == "00";
                    string frequency = isMonthly ? "ماهانه" : "روزانه";
                    return $"{frequency} " +
                        $"تعداد کنتورها : {HexToDecimalConvertor.HexToDecimal(data.Substring(2, 2))} ," +
                        $"شماره سریال کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(4, 8))} ," +
                        $"مصرف کل کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(12, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(20, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور اول :{HexDateConverter.ConvertHexToDate(data.Substring(28, 8))} ," +
                        $"شماره سریال کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(36, 8))} ," +
                        $"مصرف کل کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(44, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(52, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور دوم :{HexDateConverter.ConvertHexToDate(data.Substring(60, 8))} ,";
                }
                else if (data.Length == 100 && Code == "A3" || Code == "a3")
                {
                    // this is the data for queue and three meter
                    string firstTwoDigits = data[..2];
                    bool isMonthly = firstTwoDigits == "00";
                    string frequency = isMonthly ? "ماهانه" : "روزانه";
                    return $"{frequency} " +
                        $"تعداد کنتورها : {HexToDecimalConvertor.HexToDecimal(data.Substring(2,2))} ," +
                        $"شماره سریال کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(4, 8))} ," +
                        $"مصرف کل کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(12, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(20, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور اول :{HexDateConverter.ConvertHexToDate(data.Substring(28, 8))} ," +
                        $"شماره سریال کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(36, 8))} ," +
                        $"مصرف کل کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(44, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(52, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور دوم :{HexDateConverter.ConvertHexToDate(data.Substring(60, 8))} ," +
                        $"شماره سریال کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(68, 8))} ," +
                        $"مصرف کل کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(76, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(84, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور سوم :{HexDateConverter.ConvertHexToDate(data.Substring(92, 8))} ,";
                }
                else if (data.Length == 132 && Code == "A3" || Code == "a3")
                {
                    // this is the data for queue and four meter
                    string firstTwoDigits = data[..2];
                    bool isMonthly = firstTwoDigits == "00";
                    string frequency = isMonthly ? "ماهانه" : "روزانه";
                    return $"{frequency} " +
                        $"تعداد کنتورها : {HexToDecimalConvertor.HexToDecimal(data.Substring(2,2))} ," +
                        $"شماره سریال کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(4, 8))} ," +
                        $"مصرف کل کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(12, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(20, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور اول :{HexDateConverter.ConvertHexToDate(data.Substring(28, 8))} ," +
                        $"شماره سریال کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(36, 8))} ," +
                        $"مصرف کل کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(44, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(52, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور دوم :{HexDateConverter.ConvertHexToDate(data.Substring(60, 8))} ," +
                        $"شماره سریال کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(68, 8))} ," +
                        $"مصرف کل کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(76, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(84, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور سوم :{HexDateConverter.ConvertHexToDate(data.Substring(92, 8))} ," +
                        $"شماره سریال کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(100, 8))} ," +
                        $"مصرف کل کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(108, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(116, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور چهارم :{HexDateConverter.ConvertHexToDate(data.Substring(124, 8))} ,";
                }
                else if (data.Length == 164 && Code == "A3" || Code == "a3")
                {
                    // this is the data for queue and five meter
                    string firstTwoDigits = data[..2];
                    bool isMonthly = firstTwoDigits == "00";
                    string frequency = isMonthly ? "ماهانه" : "روزانه";
                    return $"{frequency} " +
                        $"تعداد کنتورها : {HexToDecimalConvertor.HexToDecimal(data.Substring(2,2))} ," +
                        $"شماره سریال کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(4, 8))} ," +
                        $"مصرف کل کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(12, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(20, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور اول :{HexDateConverter.ConvertHexToDate(data.Substring(28, 8))} ," +
                        $"شماره سریال کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(36, 8))} ," +
                        $"مصرف کل کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(44, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(52, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور دوم :{HexDateConverter.ConvertHexToDate(data.Substring(60, 8))} ," +
                        $"شماره سریال کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(68, 8))} ," +
                        $"مصرف کل کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(76, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(84, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور سوم :{HexDateConverter.ConvertHexToDate(data.Substring(92, 8))} ," +
                        $"شماره سریال کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(100, 8))} ," +
                        $"مصرف کل کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(108, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(116, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور چهارم :{HexDateConverter.ConvertHexToDate(data.Substring(124, 8))} ," +
                        $"شماره سریال کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(132, 8))} ," +
                        $"مصرف کل کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(140, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(148, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور پنجم :{HexDateConverter.ConvertHexToDate(data.Substring(156, 8))} ,";
                }
                else if (data.Length == 196 && Code == "A3" || Code == "a3")
                {
                    // this is the data for queue and six meter
                    string firstTwoDigits = data[..2];
                    bool isMonthly = firstTwoDigits == "00";
                    string frequency = isMonthly ? "ماهانه" : "روزانه";
                    return $"{frequency} " +
                        $"تعداد کنتورها : {HexToDecimalConvertor.HexToDecimal(data.Substring(2, 2))} ," +
                        $"شماره سریال کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(4, 8))} ," +
                        $"مصرف کل کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(12, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(20, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور اول :{HexDateConverter.ConvertHexToDate(data.Substring(28, 8))} ," +
                        $"شماره سریال کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(36, 8))} ," +
                        $"مصرف کل کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(44, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(52, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور دوم :{HexDateConverter.ConvertHexToDate(data.Substring(60, 8))} ," +
                        $"شماره سریال کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(68, 8))} ," +
                        $"مصرف کل کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(76, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(84, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور سوم :{HexDateConverter.ConvertHexToDate(data.Substring(92, 8))} ," +
                        $"شماره سریال کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(100, 8))} ," +
                        $"مصرف کل کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(108, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(116, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور چهارم :{HexDateConverter.ConvertHexToDate(data.Substring(124, 8))} ," +
                        $"شماره سریال کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(132, 8))} ," +
                        $"مصرف کل کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(140, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(148, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور پنجم :{HexDateConverter.ConvertHexToDate(data.Substring(156, 8))} ," +
                        $"شماره سریال کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(164, 8))} ," +
                        $"مصرف کل کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(172, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(180, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور ششم :{HexDateConverter.ConvertHexToDate(data.Substring(188, 8))} ,";
                }
                else if (data.Length == 228 && Code == "A3" || Code == "a3")
                {
                    // this is the data for queue and seven meter
                    string firstTwoDigits = data[..2];
                    bool isMonthly = firstTwoDigits == "00";
                    string frequency = isMonthly ? "ماهانه" : "روزانه";
                    return $"{frequency} " +
                        $"تعداد کنتورها : {HexToDecimalConvertor.HexToDecimal(data.Substring(2, 2))} ," +
                        $"شماره سریال کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(4, 8))} ," +
                        $"مصرف کل کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(12, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(20, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور اول :{HexDateConverter.ConvertHexToDate(data.Substring(28, 8))} ," +
                        $"شماره سریال کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(36, 8))} ," +
                        $"مصرف کل کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(44, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(52, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور دوم :{HexDateConverter.ConvertHexToDate(data.Substring(60, 8))} ," +
                        $"شماره سریال کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(68, 8))} ," +
                        $"مصرف کل کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(76, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(84, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور سوم :{HexDateConverter.ConvertHexToDate(data.Substring(92, 8))} ," +
                        $"شماره سریال کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(100, 8))} ," +
                        $"مصرف کل کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(108, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(116, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور چهارم :{HexDateConverter.ConvertHexToDate(data.Substring(124, 8))} ," +
                        $"شماره سریال کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(132, 8))} ," +
                        $"مصرف کل کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(140, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(148, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور پنجم :{HexDateConverter.ConvertHexToDate(data.Substring(156, 8))} ," +
                        $"شماره سریال کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(164, 8))} ," +
                        $"مصرف کل کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(172, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(180, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور ششم :{HexDateConverter.ConvertHexToDate(data.Substring(188, 8))} ," +
                        $"شماره سریال کنتور هفتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(196, 8))} ," +
                        $"مصرف کل کنتور هفتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(204, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور هفتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(212, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور هفتم :{HexDateConverter.ConvertHexToDate(data.Substring(220, 8))} ,";
                }
                else if (data.Length == 260 && Code == "A3" || Code == "a3")
                {
                    // this is the data for queue and eight meter
                    string firstTwoDigits = data[..2];
                    bool isMonthly = firstTwoDigits == "00";
                    string frequency = isMonthly ? "ماهانه" : "روزانه";
                    return $"{frequency} " +
                        $"تعداد کنتورها : {HexToDecimalConvertor.HexToDecimal(data.Substring(2, 2))} ," +
                        $"شماره سریال کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(4, 8))} ," +
                        $"مصرف کل کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(12, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور اول :{HexToDecimalConvertor.HexToDecimal(data.Substring(20, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور اول :{HexDateConverter.ConvertHexToDate(data.Substring(28, 8))} ," +
                        $"شماره سریال کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(36, 8))} ," +
                        $"مصرف کل کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(44, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور دوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(52, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور دوم :{HexDateConverter.ConvertHexToDate(data.Substring(60, 8))} ," +
                        $"شماره سریال کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(68, 8))} ," +
                        $"مصرف کل کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(76, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور سوم :{HexToDecimalConvertor.HexToDecimal(data.Substring(84, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور سوم :{HexDateConverter.ConvertHexToDate(data.Substring(92, 8))} ," +
                        $"شماره سریال کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(100, 8))} ," +
                        $"مصرف کل کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(108, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور چهارم :{HexToDecimalConvertor.HexToDecimal(data.Substring(116, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور چهارم :{HexDateConverter.ConvertHexToDate(data.Substring(124, 8))} ," +
                        $"شماره سریال کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(132, 8))} ," +
                        $"مصرف کل کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(140, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور پنجم :{HexToDecimalConvertor.HexToDecimal(data.Substring(148, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور پنجم :{HexDateConverter.ConvertHexToDate(data.Substring(156, 8))} ," +
                        $"شماره سریال کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(164, 8))} ," +
                        $"مصرف کل کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(172, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور ششم :{HexToDecimalConvertor.HexToDecimal(data.Substring(180, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور ششم :{HexDateConverter.ConvertHexToDate(data.Substring(188, 8))} ," +
                        $"شماره سریال کنتور هفتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(196, 8))} ," +
                        $"مصرف کل کنتور هفتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(204, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور هفتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(212, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور هفتم :{HexDateConverter.ConvertHexToDate(data.Substring(220, 8))} ," +
                        $"شماره سریال کنتور هشتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(228, 8))} ," +
                        $"مصرف کل کنتور هشتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(236, 8)) / 10} لیتر ," +
                        $"مصرف {frequency} کنتور هشتم :{HexToDecimalConvertor.HexToDecimal(data.Substring(244, 8)) / 10} لیتر  ," +
                        $"زمان تخلیه اطلاعات کنتور هشتم :{HexDateConverter.ConvertHexToDate(data.Substring(252, 8))} ,";
                }
                else if (data.Length == 4)
                {
                    return "بدون اطلاعات";
                }
                else
                {
                    return "پکت تعریف نشده";
                }

            }
        }
    }
}
