using System;

namespace Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Храната на котката за месец е с 25 % по - скъпа от тоалетната, а
            //играчките са с 50 % по - евтини от храната. 
            //Посещението при ветеринар на месец е с 10 % по - скъпо от играчките. 
            //Всеки месец трябва да се отделят средства за непредвидени разходи, които са 5 % от общият разход за 1 месец.
            // Напишете програма, която пресмята колко са разходите около една котка за една година. 
            //Вход:

            double bedPr = double.Parse(Console.ReadLine());
            double toiletPr = double.Parse(Console.ReadLine());

            double month = toiletPr + 1.25 * toiletPr + .5 * (1.25 * toiletPr) + 1.1 * (.5 * (1.25 * toiletPr)) + 
                .05* (toiletPr + 1.25 * toiletPr + .5 * (1.25 * toiletPr) + 1.1 * (.5 * (1.25 * toiletPr)));
            double output = month * 12 + bedPr;

            Console.WriteLine($"{output:f2} lv.");
//Изход:
//            Да се отпечата на конзолата един ред:
//            { разходът за една година}
//            lv.
//Резултатът да се закръгли до втория знак след десетичната запетая.

        }
    }
}
