using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please, enter the date in format dd.mm.yyyy: ");
            while (true)
            {
                try
                {
                    string dateAsString = Console.ReadLine();
                    InputDate date = new InputDate();
                    DateTime datetime = InputDate.ParseDate(dateAsString);
                    DateCalculation calculate = new DateCalculation();
                    bool result = calculate.IsLeapYear(datetime);
                    if (result)
                    {
                        calculate.СountWithoutYear(datetime);
                    }
                    else
                    {
                        calculate.СountWithYear(datetime);
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid format date! Format date: dd.mm.yyyy");
                    Environment.Exit(0);
                }
            }
        }
    }
}
