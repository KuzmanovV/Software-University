using System;

namespace _10.LowrToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            char character = Console.ReadLine()[0];
            string output = "";

            if ((int) character > 96)
            {
                output = "lower-case";
            }
            else
            {
                output = "upper-case";
            }
            
            Console.WriteLine(output);
        }
    }
}
