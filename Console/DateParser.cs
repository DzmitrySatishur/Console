using System;
using System.Globalization;

namespace ConsoleApp2
{
    public class DateParser
    {
        public static DateTime ParseDate(string dateAsString) => 
            DateTime.ParseExact(dateAsString, "dd.MM.yyyy", CultureInfo.InvariantCulture);
    }
}
