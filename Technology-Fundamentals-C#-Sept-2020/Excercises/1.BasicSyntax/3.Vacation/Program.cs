using System;

namespace _3.Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            var type = Console.ReadLine();
            var day = Console.ReadLine();

            double price = 0;
            double totalPrice = 0;
            
            switch (type)
            {
                case "Students":
                    switch (day)
                    {
                        case "Friday": price = 8.45; break;
                        case "Saturday": price = 9.8; break;
                        case "Sunday": price = 10.46; break;
                    }
                    
                    if (number >= 30)
                    {
                        totalPrice = number * price * .85;
                    }
                    else
                    {
                        totalPrice = number * price;
                    }
                    break;
                case "Business":
                    switch (day)
                    {
                        case "Friday": price = 10.9; break;
                        case "Saturday": price = 15.6; break;
                        case "Sunday": price = 16; break;
                    }
                    
                    if (number >= 100)
                    {
                        totalPrice = (number-10) * price;
                    }
                    else
                    {
                        totalPrice = number * price;
                    }
                    break;
                case "Regular":
                    switch (day)
                    {
                        case "Friday": price = 15; break;
                        case "Saturday": price = 20; break;
                        case "Sunday": price = 22.5; break;
                    }
                    
                    if (number >= 10 && number <= 20)
                    {
                        totalPrice = .95 * number * price;
                    }
                    else
                    {
                        totalPrice = number * price;
                    }
                    break;

            }

            Console.WriteLine($"Total price: {totalPrice:f2}");
        }
    }
}
