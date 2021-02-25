using System;

namespace _04converter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string from = Console.ReadLine();
            string to = Console.ReadLine();
            double res = 0;
            if (from=="mm"&&to=="cm")
            {
                res = number / 10.0;
            }
            else if (from=="mm"&&to=="m")
            {
                res = number / 1000.0;
            }
            else if (from == "m" && to == "mm")
            {
                res = number * 1000;
            }
            else if (from == "m" && to == "cm")
            {
                res = number * 100;
            }
            else if (from == "cm" && to == "m")
            {
                res = number / 100.0;
            } 
            else if (from == "cm" && to == "mm")
            {
                res = number * 10;
            }
            Console.WriteLine($"{res:f3}");
        }
    }
}
