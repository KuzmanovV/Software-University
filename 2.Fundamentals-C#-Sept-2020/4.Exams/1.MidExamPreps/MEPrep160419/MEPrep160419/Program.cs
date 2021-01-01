using System;

namespace MEPrep160419
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double flourPr = double.Parse(Console.ReadLine());

            double eggsPr = .75 * flourPr; //1 pack eggs
            double milkPr = 1.25 * flourPr; //1l milk
            double cozunacPr = eggsPr + flourPr + milkPr / 4;
            int eggs = 0;
            int cozunacs = 0;

            while (budget>=cozunacPr)
            {
                cozunacs++;
                budget -= cozunacPr;
                eggs += 3;

                if (cozunacs%3==0)
                {
                    eggs -= cozunacs - 2;
                }
            }

            Console.WriteLine($"You made {cozunacs} cozonacs! Now you have {eggs} eggs and {budget:f2}BGN left.");
        }
    }
}
