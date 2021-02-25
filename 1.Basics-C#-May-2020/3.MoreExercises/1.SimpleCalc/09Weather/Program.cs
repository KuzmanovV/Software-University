using System;

namespace _09Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            //При въвеждане на "sunny" трябва да се отпечата "It's warm outside!".
            //Във всички останали случаи трябва да се отпечата "It's cold outside!".
            string weather = Console.ReadLine();
            if (weather == "sunny")
            {
                Console.WriteLine("It's warm outside!");
            }
            else
            {
                Console.WriteLine("It's cold outside!");
            }
         }
    }
}
