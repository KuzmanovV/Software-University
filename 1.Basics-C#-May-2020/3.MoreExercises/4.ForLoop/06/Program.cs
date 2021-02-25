using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Първи ред – месеците за които се търси средният разход – цяло число в интервала [1...100]
            За всеки месец – сметката за ток – реално число в интервала [1.00...1000.00]*/

            int months = int.Parse(Console.ReadLine());
            double totalEl = 0.0;
            double totalW = 0.0;
            double totalInt = 0.0;
            double totalOth = 0.0;
            double totalTotal = 0.0;

            for (int i = 0; i < months; i++)
            {
                double electricity = double.Parse(Console.ReadLine());
                totalEl += electricity;
                totalW += 20;
                totalInt += 15;
                totalOth += (15+20+electricity)*1.20;
                totalTotal = totalEl + totalW + totalInt + totalOth; /*!*/
            }
            
            Console.WriteLine($"Electricity: {totalEl:f2} lv");
            Console.WriteLine($"Water: {totalW:f2} lv");
            Console.WriteLine($"Internet: {totalInt:f2} lv");
            Console.WriteLine($"Other: {totalOth:f2} lv");
            Console.WriteLine($"Average: {totalTotal/months:f2} lv");

            /*•	1ви ред: ""
              •	2ри ред: "Water: {вода за всички месеци} lv"
              •	3ти ред: "Internet: {интернет за всички месеци} lv"
              •	4ти ред: "Other: {други за всички месеци} lv"
              •	5ти ред: "Average: {средно всички разходи за месец} lv"
              Всички числа трябва да са форматирана до вторият знак след запетаята.*/
        }
    }
}
