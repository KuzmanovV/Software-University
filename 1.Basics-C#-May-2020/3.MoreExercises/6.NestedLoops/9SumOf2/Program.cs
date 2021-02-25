using System;

namespace _9SumOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред – начало на интервала – цяло число в интервала[1...999]
            //•	Втори ред – край на интервала – цяло число в интервала[по - голямо от първото число...1000]
            //•	Трети ред – магическото число – цяло число в интервала[1...10000]

            int s = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int combination = 0;
            bool none = true;

            for (int i = s; i <= e; i++)
            {
                for (int j = s; j <= e; j++)
                {
                    combination++;

                    if ((i+j)==m)
                    {
                        Console.WriteLine($"Combination N:{combination} ({i} + {j} = {m})");
                        none = false;
                        break;
                    }
                }

                if (!none)
                {
                    break;
                }
            }

            if (none)
            {
                Console.WriteLine($"{combination} combinations - neither equals {m}");
            }
        }
    }
}
