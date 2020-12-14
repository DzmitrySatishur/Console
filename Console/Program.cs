using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Press 'Y' for start program or 'N' for exit");
            try
            {
                while (true)
                {
                    const char yes = 'Y';
                    const char no = 'N';
                    char userChoice = Convert.ToChar(Console.ReadLine().ToUpperInvariant());
                    if (userChoice == yes)
                    {
                        try
                        {
                            Console.WriteLine("Please, enter the date in format dd.mm.yyyy: ");
                            string dateAsString = Console.ReadLine();
                            DateTime datetime = InputDate.ParseDate(dateAsString);
                            DateCalculation calculate = new DateCalculation();
                            bool result = calculate.IsLeapYear(datetime);
                            if (result)
                                calculate.СountWithoutYear(datetime);
                            else
                                calculate.СountWithYear(datetime);
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid date format! Try again? Y/N");
                        }
                    }
                    else if (userChoice == no)
                    {
                        Console.WriteLine("Goodbye!");
                        Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Incorrect symbols.Press Y or N");
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Incorrect symbols. Press Y for start or N for exit");
            }
        }
    }
}
