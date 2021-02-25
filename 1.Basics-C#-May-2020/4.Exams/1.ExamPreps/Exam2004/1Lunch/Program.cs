using System;

namespace _1Lunch
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Козунак  – 3.20 лв.
            //•	Яйца –  4.35 лв.за кора с 12 яйца
            //•	Курабии – 5.40 лв.за килограм
            //•	Боя за яйца - 0.15 лв.за яйце
            

            int breads = int.Parse(Console.ReadLine());
            int eggs = int.Parse(Console.ReadLine());
            int cookies = int.Parse(Console.ReadLine());

            double expences = breads * 3.2 + eggs * 4.35 + cookies * 5.4 + eggs * 12 * .15;

            Console.WriteLine($"{expences:f2}");

//Да се отпечата на конзолата колко ще са разходите по приготвянето на обяда. Сумата да бъде форматирана до втория знак след десетичната запетая.

        }
    }
}
