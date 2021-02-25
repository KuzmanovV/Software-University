using System;

namespace PBExam2803Train
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  На първия ред – броят биткойни. Цяло число в интервала [0…20]
На втория ред – броят китайски юана. Реално число в интервала [0.00… 50 000.00]
На третия ред – комисионната. Реално число в интервала [0.00 ... 5.00]
1 биткойн = 1168 лева.
1 китайски юан = 0.15 долара.
1 долар = 1.76 лева.
1 евро = 1.95 лева.*/

            int bits = int.Parse(Console.ReadLine());
            double yoans = double.Parse(Console.ReadLine());
            double commision = double.Parse(Console.ReadLine());

            double USD = yoans * .15;
            double BGN = bits * 1168 + USD * 1.76;
            double EUR = BGN / 1.95 * (1 - commision / 100.00);

            Console.WriteLine($"{EUR:f2}");
            /*  1 число - резултатът от обмяната на валутите.
             *    Резултатът да се форматира до втората цифра след десетичната запетая.   */

        }
    }
}
