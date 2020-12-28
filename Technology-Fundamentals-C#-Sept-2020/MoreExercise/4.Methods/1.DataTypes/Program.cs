using System;

namespace Methods_ME
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "int": Do(int.Parse(Console.ReadLine())); break;
                case "real": Do(double.Parse(Console.ReadLine())); break;
                case "string": Do(Console.ReadLine()); break;
            }
        }

        private static void Do(int v)
        {
            Console.WriteLine(v*2);
        }
        private static void Do(double v)
        {
            Console.WriteLine($"{v*1.5:f2}");
        }
        private static void Do(string v)
        {
            Console.WriteLine($"${v}$");
        }
    }
}
