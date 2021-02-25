using System;

namespace Mushr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mushroom ? gr");
            string gr = Console.ReadLine();
            int total = 0;
            int thirdTotal = 0;

            while (gr!="End")
            {
                int parsedGr = int.Parse(gr);
                total += parsedGr;
                if (total/3.0 >= thirdTotal)
                {
                Console.WriteLine("Leave it:)");
                thirdTotal += parsedGr;
                }
                gr = Console.ReadLine();
                
            }
            Console.WriteLine($"You found {total} gr of mushrooms and left {100.0*thirdTotal/total:f2}%");
        }
    }
}
