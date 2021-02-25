using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Първи ред - колко хода ще има по време на играта – цяло число в интервала [1...100]
За всеки ход – числата, които се проверяват в кой интервал са – цели числа в интервала [-100...100]
От 0 до 9  20 % от числото
От 10 до 19  30 % от числото
От 20 до 29  40 % от числото
От 30 до 39  50 точки
От 40 до 50  100 точки
Невалидно число  резултата се дели на 2*/

            double turns = double.Parse(Console.ReadLine());
            double result = 0.0;
            int first = 0;
            int second = 0;
            int third = 0;
            int fourth = 0;
            int fifth = 0;
            int sixth = 0;

            for (int i = 0; i < turns; i++)
            {
                int cTurn = int.Parse(Console.ReadLine());

                if (cTurn>=0 && cTurn<10)
                {
                    first++;
                    result += cTurn * 20 / 100.0;
                }
                else if (cTurn>=10 && cTurn<20)
                {
                    second++;
                    result += cTurn * 30 / 100.0;
                }
                else if (cTurn>=20 && cTurn<30)
                {
                    third++;
                    result += cTurn * 40 / 100.0;
                }
                else if (cTurn>=30 && cTurn<40)
                {
                    fourth++;
                    result += 50;
                }
                else if (cTurn>=40 && cTurn<=50)
                {
                    fifth++;
                    result += 100;
                }
                else
                {
                    sixth++;
                    result /= 2;
                }
            }

            Console.WriteLine($"{result:f2}");
            Console.WriteLine($"From 0 to 9: {first/turns*100:f2}%");
            Console.WriteLine($"From 10 to 19: {second/turns*100:f2}%");
            Console.WriteLine($"From 20 to 29: {third/turns*100:f2}%");
            Console.WriteLine($"From 30 to 39: {fourth/turns*100:f2}%");
            Console.WriteLine($"From 40 to 50: {fifth/turns*100:f2}%");
            Console.WriteLine($"Invalid numbers: {sixth/turns*100:f2}%");

        }
    }
}
