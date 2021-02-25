using System;

namespace _11Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            //            За всеки четен ден и нечетен час, паркингът таксува 2.50 лева.
            //Във всеки нечетен ден и четен час таксата е 1.25 лева, 
            //във всички останали случаи се заплаща 1 лев.
            //Таксуването става на всеки изминал час от деня. 
            //Всеки един от изходите трябва да бъде закръглен до втория знак
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double totalPerDay = 0;
            double total = 0;
            int dayCounter = 0;

            for (int i = 1; i <= days; i++)
            {
                for (int j = 1; j <= hours; j++)
                {
                    if (i%2==0 && j%2!=0)
                    {
                        totalPerDay += 2.5;
                    }
                    else if (i%2!=0 && j%2==0)
                    {
                        totalPerDay += 1.25;
                    }
                    else
                    {
                        totalPerDay += 1;
                    }
                }
                dayCounter++;
                Console.WriteLine($"Day: {dayCounter} - {totalPerDay:f2} leva");
                total += totalPerDay;
                totalPerDay = 0;
            }

            Console.WriteLine($"Total: {total:f2} leva");
        }
    }
}
