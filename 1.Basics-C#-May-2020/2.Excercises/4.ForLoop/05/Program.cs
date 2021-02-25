using System;

namespace ForCicle_Excersise
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 0; i < n; i++)
            {
            int cNum = int.Parse(Console.ReadLine());

                if (cNum%2==0)
                {
                    p1++;
                }
                if (cNum % 3 == 0)
                {
                    p2++;
                }
                if (cNum % 4 == 0)
                {
                    p3++;
                }
            }

            Console.WriteLine($"{p1/n*100:f2}%");
            Console.WriteLine($"{p2/n*100:f2}%");
            Console.WriteLine($"{p3/n*100:f2}%");

        }
    }
}
