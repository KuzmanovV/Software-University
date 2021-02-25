using System;

namespace _1PINs
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Горната граница на първото число - цяло число в диапазона[1...9]
            //•	Горната граница на второто число - цяло число в диапазона[1...9]
            //•	Горната граница на третото число - цяло число в диапазона[1...9]
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int x3 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x1; i++)
            {
                for (int j = 1; j <= x2; j++)
                {
                    for (int k = 1; k <= x3; k++)
                    {
                        if (i%2==0)
                        {
                            if (j==2 || j==3 || j==5 || j==7)
                            {
                                if (k%2==0)
                                {
                                    Console.WriteLine($"{i} {j} {k}");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
