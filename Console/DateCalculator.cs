using System;

namespace ConsoleApp2
{
    public class DateCalculator
    {
        public int Count(DateTime dateTime) =>
            IsLeapYear(dateTime.Year) && dateTime.Month <= 2
                ? 60 - dateTime.DayOfYear
                : GetDaysUntilYearEnd(dateTime) + (GetNextLeapYear(dateTime.Year) - dateTime.Year - 1) * 365 + 60;

        private static bool IsLeapYear(int year) => year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);

        private static int GetDaysUntilYearEnd(DateTime dateTime) => (IsLeapYear(dateTime.Year) ? 366 : 365) - dateTime.DayOfYear;

        private static int GetNextLeapYear(int year)
        {
            var tempYear = year + 1;

            while (!IsLeapYear(tempYear))
            {
                tempYear++;
            }

            return tempYear;
        }
    }
}
