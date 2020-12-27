using System;

namespace _8.BeerKegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            double maxVolume = 0;
            string maxName = "";

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double radius = double.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                double volume = height * Math.PI * Math.Pow(radius, 2);

                if (volume > maxVolume)
                {
                    maxVolume = volume;
                    maxName = name;
                }
            }

            Console.WriteLine(maxName);
        }
    }
}
