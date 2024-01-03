using System.Globalization;
using System.Text;

namespace Terminal.Convertors
{
    public static class TimeCalculator
    {
       public static string ConvertMiladiToshamsi() 
        {
            DateTime now = DateTime.Now;
            PersianCalendar persianCalendar = new();
            int persianYear = persianCalendar.GetYear(now);
            int persianMonth = persianCalendar.GetMonth(now);
            int persianDay = persianCalendar.GetDayOfMonth(now);
            int persianHour = persianCalendar.GetHour(now);
            int persianMinute = persianCalendar.GetMinute(now);
            int persianSecond = persianCalendar.GetSecond(now);
            StringBuilder persianDateTimeString = new();
            persianDateTimeString.Append($"{persianYear:0000}-{persianMonth:00}-{persianDay:00} ");
            persianDateTimeString.Append($"{persianHour:00}:{persianMinute:00}:{persianSecond:00}");
            return (persianDateTimeString.ToString());
        }
    }
}
