using System;

namespace ConsoleApp2
{
    public class DateCalculation
    {
        public bool IsLeapYear(DateTime dateTime)
        {
            if (dateTime.Year % 4 == 0 && (dateTime.Year % 100 != 0 || dateTime.Year % 400 == 0))
            {
                return true;
            }
            return false;
        }

        public void СountWithYear(DateTime dateTime)
        {
            var newDate = new DateTime (dateTime.Year, dateTime.Month, dateTime.Day);
            DateTime  tempDate;
            while (true)
            {
                if (newDate.Year % 4 == 0 && (newDate.Year % 100 != 0 || newDate.Year % 400 == 0))
                {
                    tempDate = new DateTime(newDate.Year, newDate.Month, newDate.Day);
                    break;
                }
                else
                {
                   newDate = newDate.AddYears(1);
                }
            }

            DateTime needDate = new DateTime(tempDate.Year, 02, 29);
            int numbOfDays = (needDate - tempDate).Days + ((needDate.Year - dateTime.Year) * 365);
            Console.WriteLine(numbOfDays + " days left to 29 February");
        }

        public void СountWithoutYear(DateTime dateTime)
        {
            if (dateTime.Year % 4 == 0 && (dateTime.Year % 100 != 0 || dateTime.Year % 400 == 0))
            {
                var date = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
                if (date > new DateTime(
                    dateTime.Year, 02, 29))
                {
                    СountWithYear(date.AddYears(1));
                }
                else
                {
                    int daysOfLeapYear = (new DateTime(dateTime.Year, 02, 29) - date).Days;
                    Console.WriteLine(daysOfLeapYear + " days left to 29 February");
                }
            }
        }
    }
}

