using System;

namespace Excersise2Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            int forth = int.Parse(Console.ReadLine());
            int a = first + second;
            int b = a / third;
            Console.WriteLine(b*forth);
        }
    }
}
