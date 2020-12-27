using System;

namespace _10.Rage
{
    class Program
    {
        static void Main(string[] args)
        {
            int lost = int.Parse(Console.ReadLine());
            double headset = double.Parse(Console.ReadLine());
            double mouse = double.Parse(Console.ReadLine());
            double keyboard = double.Parse(Console.ReadLine());
            double display = double.Parse(Console.ReadLine());

            double expences = lost / 2 * headset + lost / 3 * mouse + lost / 6 * keyboard + lost / 12 * display;

            Console.WriteLine($"Rage expenses: {expences:f2} lv.");
        }
    }
}
