using System;
using System.Globalization;

namespace ConsoleApp2
{
    public class InputDate
    {
        public static DateTime ParseDate(string dateAsString)
        {
            var inputDate = DateTime.ParseExact(dateAsString, "dd.MM.yyyy", CultureInfo.InvariantCulture);
            return inputDate;
        }
    }
}
