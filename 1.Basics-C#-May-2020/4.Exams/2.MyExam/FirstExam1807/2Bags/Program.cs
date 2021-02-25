using System;

namespace _2Bags
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	до 10кг – 20 % от цената на багаж над 20кг
            //•	между 10кг и 20кг вкл. – 50 % от цената на багаж над 20кг.
            //•	над 20кг – таксата се чете от конзолата

           //В зависимост от броя на дните, които остават до пътуването, цената се оскъпява:
            //•	повече от 30 дни - цената на багажа се оскъпява с 10 %
            //•	между 7 и 30 дни вкл. -цената на багажа се оскъпява с 15 %
            //•	по - малко от 7 дни - цената на багажа се оскъпява с 40 %
          
            double prOver20 = double.Parse(Console.ReadLine());
            double weight = double.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int bags = int.Parse(Console.ReadLine());

            if (weight<10)
            {
                prOver20 *= .2;
            }
            else if (weight>=10 && weight<=20)
            {
                prOver20 *= .5;
            }

            if (days>30)
            {
                prOver20 *= 1.1;
            }
            else if (days>=7 && days<=30)
            {
                prOver20 *= 1.15;
            }
            else if (days<7)
            {
                prOver20 *= 1.4;
            }

            Console.WriteLine($"The total price of bags is: {prOver20*bags:f2} lv.");

//Да се отпечата на конзолата сумата, която ще трябва да заплати Мими за багажите, в следния формат:
//•	"  "
//Сумата да бъде форматирана до втората цифра след десетичния знак.

        }
    }
}
