using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1.	Капацитетът на стадиона – цяло число в интервала [1 … 10000];
           2.	Броят на всички фенове – цяло число в интервала [1 … 10000].
           За всеки един фен, на отделен ред се прочита:
           1.	Секторът, на който се намира – текст – "A", "B", "V" и "G"  */

            int capacity = int.Parse(Console.ReadLine());
            double fans = double.Parse(Console.ReadLine());
            int countA = 0;
            int countB = 0;
            int countV = 0;
            int countG = 0;

            for (int i = 0; i < fans; i++)
            {
                string sector = Console.ReadLine();

                switch (sector)
                {
                    case "A": countA++; break;
                    case "B": countB++; break;
                    case "V": countV++; break;
                    case "G": countG++; break;
                }
            }

            Console.WriteLine($"{countA/fans*100:f2}%");
            Console.WriteLine($"{countB/fans*100:f2}%");
            Console.WriteLine($"{countV/fans*100:f2}%");
            Console.WriteLine($"{countG/fans*100:f2}%");
            Console.WriteLine($"{fans/capacity*100:f2}%");

            /*  5 реда, всеки от които съдържа процент между 0.00% и 100.00%, форматирани до втората цифра след десетичната запетая:
1.	Процентът на феновете в сектор А
2.	Процентът на феновете в сектор Б
3.	Процентът на феновете в сектор В
4.	Процентът на феновете в сектор Г
5.	Процентът на всички фенове, спрямо капацитета на стадиона.  */
        }
    }
}
