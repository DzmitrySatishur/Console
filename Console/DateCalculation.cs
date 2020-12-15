using System;

namespace ConsoleApp2
{
    public class DateCalculation
    {
        public bool IsLeapYear(DateTime dateTime)
        {
            return dateTime.Year % 4 == 0 && (dateTime.Year % 100 != 0 || dateTime.Year % 400 == 0);
        }

        public void СountWithYear(DateTime dateTime)
        {
            var newDate = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
            DateTime tempDate;
            while (true)
            {
                if (IsLeapYear(newDate))
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
            Console.WriteLine(numbOfDays + " days left to 29 February \nTry again? Y/N");
        }

        public void СountWithoutYear(DateTime dateTime)
        {
            if (IsLeapYear(dateTime))
            {
                var date = new DateTime(dateTime.Year, dateTime.Month, dateTime.Day);
                if (date > new DateTime(
                    dateTime.Year, 02, 29))
                {
                    DateTime needDate = new DateTime(date.Year, 02, 29);
                    int tempDays = (date - needDate).Days;
                    DateTime tempDate;
                    date = date.AddYears(1);
                    while (true)
                    {
                        if (IsLeapYear(date))
                        {
                            tempDate = new DateTime(date.Year, date.Month, date.Day);
                            break;
                        }
                        else
                        {
                            date = date.AddYears(1);
                        }
                    }

                    var countOfDays = ((tempDate.Year - dateTime.Year) * 365) - tempDays;
                    Console.WriteLine(countOfDays + " days left to 29 February \nTry again? Y/N");
                }
                else
                {
                    int daysOfLeapYear = (new DateTime(dateTime.Year, 02, 29) - date).Days;
                    Console.WriteLine(daysOfLeapYear + " days left to 29 February \nTry again? Y/N");
                }
            }
        }
    }
}

