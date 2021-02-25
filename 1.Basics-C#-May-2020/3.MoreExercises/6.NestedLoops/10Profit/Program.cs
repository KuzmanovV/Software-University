using System;

namespace _10Profit
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1.Брой монети по 1лв. - цяло положително число;
            //            2.Брой монети по 2лв. - цяло положително число;
            //            3.Брой банкноти по 5лв. - цяло положително число;
            //            4.Сума - цяло положително число в интервала[1…1000

            int one = int.Parse(Console.ReadLine());
            int two = int.Parse(Console.ReadLine());
            int five = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i <= one; i++)
            {
                for (int j = 0; j <= two; j++)
                {
                    for (int k = 0; k <= five; k++)
                    {
                        if (i+2*j+5*k==sum)
                        {
                            Console.WriteLine($"{i} * 1 lv. + {j} * 2 lv. + {k} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }


//o   ""
        }
    }
}
