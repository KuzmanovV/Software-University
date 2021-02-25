using System;

namespace _03Logistics
{
    class Program
    {
        static void Main(string[] args)
        {
            /*На първия ред – броя на товарите за превоз – цяло число в интервала [1...1000]
За всеки един товар на отделен ред – тонажа на товара – цяло число в интервала [1...1000]*/

            int loads = int.Parse(Console.ReadLine());
            double total = 0;
            double totalWeight = 0; 
            double p1 = 0.0;
            double p2 = 0.0;
            double p3 = 0.0;

            for (int i = 1; i <= loads; i++)
            {
                int weight = int.Parse(Console.ReadLine());
                totalWeight += weight;

                if (weight <= 3)
                {
                    total = total + weight * 200;
                    p1+=weight;
                }
                else if (weight <= 11)
                {
                    total += weight * 175;
                    p2+=weight;
                }
                else
                {
                    total += weight * 120;
                    p3+=weight;
                }

            }

            Console.WriteLine($"{total / totalWeight:f2}");
            Console.WriteLine($"{p1 / totalWeight * 100:f2}%");
            Console.WriteLine($"{p2 / totalWeight * 100:f2}%");
            Console.WriteLine($"{p3 / totalWeight * 100:f2}%");

            /*Първи ред – средната цена на тон превозен товар (закръглена до втория знак след дес. запетая);
Втори ред – процентът тона превозвани с микробус (процент между 0.00% и 100.00%);
Трети ред – процентът  тона превозвани с камион (процент между 0.00% и 100.00%);
Четвърти ред – процентът тона превозвани с влак (процент между 0.00% и 100.00%).
*/
        }
    }
}
