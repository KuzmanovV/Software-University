using System;

namespace PBExam2803Train
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Първи ред - брой пакети химикали. Цяло число в интервала [0...100]
Втори ред - брой пакети маркери. Цяло число в интервала [0...100]
Трети ред - литър препарат за почистване на дъска. Реално число в интервала [0.00…50.00]
Четвърти ред - процентът намаление. Цяло число в интервала [0...100]
            Пакет химикали - 5.80 лв 
Пакет маркери - 7.20 лв 
Препарат - 1.20 лв (за литър)*/


            int pens = int.Parse(Console.ReadLine());
            int marks = int.Parse(Console.ReadLine());
            double litres = double.Parse(Console.ReadLine());
            int discProc = int.Parse(Console.ReadLine());

            Console.WriteLine($"{(pens*5.8+marks*7.2+litres*1.2)*(1-discProc/100.00):f3}");
            /*     */

        }
    }
}
