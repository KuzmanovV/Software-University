using System;

namespace Exam2004
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	цената на килограм захар е с 25 % по - ниска от тази на килограм брашно
            //•	цената на една кора с яйца е с 10 % по - висока от цената на килограм брашно
            //•	цената на един пакет мая е с 80 % по - ниска от цената на килограм захар
            //   Вход
            
            double prFlour = double.Parse(Console.ReadLine());
            double qtyFlour = double.Parse(Console.ReadLine());
            double qtySugar = double.Parse(Console.ReadLine());
            int qtyAggs = int.Parse(Console.ReadLine());
            int qtyFerment = int.Parse(Console.ReadLine());

            double total = prFlour * qtyFlour + qtySugar * (prFlour * .75) + qtyAggs * (prFlour * 1.1)
                + qtyFerment * (.2 * (prFlour * .75));

            Console.WriteLine($"{total:f2}");

//Изход
//Да се отпечата на конзолата едно число:
//•	Сумата, която ще им е необходима, форматирана до втория знак след десетичната запетая

        }
    }
}
