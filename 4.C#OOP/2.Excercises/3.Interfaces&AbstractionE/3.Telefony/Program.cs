using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Telefony
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            string[] sites = Console.ReadLine().Split();

            foreach (var number in numbers)
            {
                bool containsSymbol = number.Any(char.IsSymbol);
                bool containsLetter = number.Any(char.IsLetter);

                if (containsLetter || containsSymbol)
                {
                    Console.WriteLine("Invalid number!");
                }
                else
                {
                    IPhonable currentNumber;

                    if (number.Length==7)
                    {
                        currentNumber = new StationaryPhone();
                    }
                    else
                    {
                        currentNumber = new Smartphone();
                    }

                    currentNumber.Call(number);
                }
            }
            foreach (var site in sites)
            {
                bool containsInt = site.Any(char.IsDigit);

                if (containsInt)
                {
                    Console.WriteLine("Invalid URL!");
                }
                else
                {
                    IBrowsable smart = new Smartphone();
                    smart.Browse(site);
                }
            }
        }
    }
}
