using System;

namespace _5Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double saved = 0;

            while (true)
            {
                string destination = Console.ReadLine();
                
                if (destination=="End")
                {
                    break;
                }
                
                double price = double.Parse(Console.ReadLine());

                while (true)
                {
                    double input = double.Parse(Console.ReadLine());
                    saved += input;
                    if (saved>=price)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        saved = 0;
                        break;
                    }
                }
                
            }
        }
    }
}
