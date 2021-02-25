using System;

namespace _07Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nights = int.Parse(Console.ReadLine());
            double prApart = 0;
            double prStud = 0;
            switch (month)
            {
                case "May":
                case "October":
                    prStud = 50 * nights;
                    prApart = 65 * nights;
                    if (nights > 14)
                    {
                        prStud *= 0.7;
                    }
                    else if (nights > 7)
                    {
                        prStud *= 0.95;
                    }
                    break;
                case "June":
                case "September":
                    prStud = 75.2 * nights;
                    prApart = 68.7 * nights; 
                   if (nights>14)
                    {
                        prStud *= 0.8;
                    }break;
                case "July":
                case "August":
                    prStud = 76 * nights;
                    prApart = 77 * nights; 
                    break;
            }
            if (nights>14)
            {
                prApart *= 0.9;
            }
            Console.WriteLine($"Apartment: {prApart:f2} lv.");
            Console.WriteLine($"Studio: {prStud:f2} lv.");
        }
    }
}
