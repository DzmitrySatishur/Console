using System;

namespace ConsoleApp2
{
    internal class Program
    {
        private const char Yes = 'Y';
        private const char No = 'N';

        private static void Main()
        {
            do
            {
                Console.WriteLine("Press 'Y' for start program or 'N' for exit");

                try
                {
                    var userChoice = Convert.ToChar(Console.ReadLine()?.ToUpperInvariant() ?? string.Empty);

                    switch (userChoice)
                    {
                        case Yes:
                        {
                            try
                            {
                                Console.WriteLine("Please, enter the date in format dd.mm.yyyy: ");

                                var datetime = DateParser.ParseDate(Console.ReadLine());
                                var dateCalculator = new DateCalculator();
                                var days = dateCalculator.Count(datetime);
                                Console.WriteLine(days + " days left to 29 February \nTry again? Y/N");
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Invalid date format! Try again? Y/N");
                            }

                            break;
                        }

                        case No:
                            Console.WriteLine("Goodbye!");
                            Environment.Exit(0);
                            break;

                        default:
                            throw new ArgumentException("Incorrect symbols.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Incorrect symbols. Press Y for start or N for exit");
                }
            } 
            while (true);
        }
    }
}
