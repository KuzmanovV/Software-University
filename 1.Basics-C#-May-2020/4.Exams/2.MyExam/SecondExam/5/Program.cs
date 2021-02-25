using System;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sea = int.Parse(Console.ReadLine());
            int mount = int.Parse(Console.ReadLine());
            string choice = Console.ReadLine();
            double profit = 0;

            while (choice!="Stop")
            {
                if (choice=="sea" && sea!=0)
                {
                    profit += 680;
                    sea--;
                }
                else if (choice=="mountain" && mount!=0)
                {
                    profit += 499;
                    mount--;
                }
                else if (sea==0 && mount==0)
                {
                    break;
                }

                choice = Console.ReadLine();
            }

            if (sea==0 && mount==0)
            {
                Console.WriteLine("Good job! Everything is sold.");
            }

            Console.WriteLine($"Profit: {profit} leva.");
        }
    }
}
