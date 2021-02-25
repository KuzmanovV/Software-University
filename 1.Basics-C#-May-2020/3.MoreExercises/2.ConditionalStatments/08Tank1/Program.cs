using System;

namespace _08Tank1
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double l = double.Parse(Console.ReadLine());
            if (fuel== "Diesel" || fuel=="Gasoline" || fuel== "Gas")
            {
                if (l < 25)
                {
                Console.WriteLine($"Fill your tank with {fuel.ToLower()}!");
                 }
                else
                {
                Console.WriteLine($"You have enough {fuel.ToLower()}.");
                 }
            }
            else
            {
                Console.WriteLine("Invalid fuel!");
            }
            
        }
    }
}
