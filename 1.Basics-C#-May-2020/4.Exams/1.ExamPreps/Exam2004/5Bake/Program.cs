using System;

namespace _5Bake
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	 Броят на козунаците – цяло число в интервала[1... 100]

            int breads = int.Parse(Console.ReadLine());
            double totalSugar = 0;
            double totalFloor = 0;
            int maxSugar = 0;
            int maxFloor = 0;

            for (int i = 1; i <= breads; i++)
            {
                int sugar = int.Parse(Console.ReadLine());
                int floor = int.Parse(Console.ReadLine());
                totalSugar += sugar;
                totalFloor += floor;

                if (sugar>maxSugar)
                {
                    maxSugar = sugar;
                }
                
                if (floor>maxFloor)
                {
                    maxFloor = floor;
                }
            }

            double packsSugar = Math.Ceiling(totalSugar*1.0 / 950);
            double packsFloor = Math.Ceiling(totalFloor / 750.0);

            Console.WriteLine($"Sugar: {packsSugar}");
            Console.WriteLine($"Flour: {packsFloor}");
            Console.WriteLine($"Max used flour is {maxFloor} grams, max used sugar is {maxSugar} grams.");

//За всеки козунак се чете:
//            o Количество изразходвана захар(грамове) – цяло число в интервала[1 … 10000]
//o Количество изразходвано брашно(грамове) – цяло число в интервала[1 … 10000]
//Изход

        }
    }
}
