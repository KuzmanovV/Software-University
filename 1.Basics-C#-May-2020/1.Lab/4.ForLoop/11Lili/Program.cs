using System;

namespace _11Lili
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Възрастта на Лили - цяло число в интервала [1...77]
Цената на пералнята – реално число
Цена на играчки – реално число*/
            int age = int.Parse(Console.ReadLine());
            double priceWM = double.Parse(Console.ReadLine());
            double priceToy = double.Parse(Console.ReadLine());
            string output = "";
            double money = 0;

            for (int i = 1; i <= age ; i++)
            {
                if (i%2==0)
                {
                    money = money + i * 5 - 1;
                }
                else
                {
                    money += priceToy;
                }
            }

            if (money>=priceWM)
            {
                output = $"Yes! {money-priceWM:f2}";
            }
            else
            {
                output = $"No! {priceWM - money:f2}";
            }



            Console.WriteLine(output);
            /*Ако парите на Лили са достатъчни:
“Yes! {N}” - където N е остатъка пари след покупката
Ако парите не са достатъчни:
“No! {М}“ - където M е сумата, която не достига
Числата N и M трябва да за форматирани до вторият знак след десетичната запетая.*/
        }
    }
}
