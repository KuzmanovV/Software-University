using System;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*На първия ред – броя на студентите явили се на изпит – цяло число в интервала [1...1000]
За всеки един студент на отделен ред – оценката от изпита – реално число в интервала [2.00...6.00]
*/

            double n = double.Parse(Console.ReadLine());
            int g1 = 0;
            int g2 = 0;
            int g3 = 0;
            int g4 = 0;
            double total = 0.0;

            for (int i = 0; i < n; i++)
            {
                double grade = double.Parse(Console.ReadLine());
                total += grade;

                if (grade>=5)
                {
                    g1++;
                }
                else if (grade>=4)
                {
                    g2++;
                }
                else if (grade>=3)
                {
                    g3++;
                }
                else
                {
                    g4++;
                }
            }
            
            Console.WriteLine($"Top students: {g1/n*100:f2}%");
            Console.WriteLine($"Between 4.00 and 4.99: {g2/n*100:f2}%");
            Console.WriteLine($"Between 3.00 and 3.99: {g3/n*100:f2}%");
            Console.WriteLine($"Fail: {g4/n*100:f2}%");
            Console.WriteLine($"Average: {total/n:f2}");

            /*Ред 1 -	
Ред 2 -	
Ред 3 -	{между 3.00 и 3.99 включително}%"
Ред 4 -	{по-малко от 3.00}%"
Ред 5 -	"Average: {среден успех}"
Всички числа трябва да са форматирани до вторият знак след десетичната запетая
*/
        }
    }
}
