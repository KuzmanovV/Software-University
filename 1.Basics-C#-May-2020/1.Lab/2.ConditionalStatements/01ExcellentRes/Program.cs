using System;

namespace _01ExcellentRes
{
    class Program
    {
        static void Main(string[] args)
        
        {
            double grade = double.Parse(Console.ReadLine());
            if (grade >= 5.5)
            { 
                Console.WriteLine("Excellent!");
            }
        }
    }
}
