using System;

namespace _08Tank2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Типа на горивото – текст с възможности: "Gas", "Gasoline" или "Diesel"
            //Количество гориво – реално число в интервала[1.00 … 50.00]
            //Притежание на клубна карта – текст с възможности: "Yes" или "No"
            string fuel = Console.ReadLine();
            double l = double.Parse(Console.ReadLine());
            string card = Console.ReadLine();
            double pay = 0;
            if (fuel == "Gas")
            {
                if (card == "Yes")
                {
                    pay = l*0.85;
                }
                else if (card=="No")
                {
                    pay = l * 0.93;
                }
                if (l >= 20 && l <= 25)
                {
                    pay = pay * 0.92;
                }
                else if (l > 25)
                {
                    pay = pay * 0.9;
                }
            }
            else if (fuel == "Gasoline")
            {
                if (card == "Yes")
                {
                    pay = l * 2.04;
                }
                else if (card=="No")
                {
                    pay = l * 2.22;
                }
                if (l >= 20 && l <= 25)
                {
                    pay = pay * 0.92;
                }
                else if (l > 25)
                {
                    pay = pay * 0.9;
                }
            }
            else if (fuel == "Diesel")
            {
                if (card == "Yes")
                {
                    pay = l * 2.21;
                }
                else if (card=="No")
                {
                    pay = l * 2.33;
                }
                if (l >= 20 && l <= 25)
                {
                    pay = pay * 0.92;
                }
                else if (l > 25)
                {
                    pay = pay * 0.9;
                }
            }
            Console.WriteLine($"{pay:f2} lv.");
        }
    }
}
