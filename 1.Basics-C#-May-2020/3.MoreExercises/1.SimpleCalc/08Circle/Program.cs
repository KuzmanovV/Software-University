using System;

namespace _08Circle
{
    class Program
    {
        static void Main(string[] args)
        {
            //конзолата число r и пресмята и отпечатва лицето и 
            //периметъра на кръг / окръжност с радиус r, като форматирате изхода в следния вид:
            //"<calculated area>" "<calculated parameter>".
            //Форматирайте изходните данни до втория знак след десетичната запетая.
            double r = double.Parse(Console.ReadLine());
            double area = r * r * Math.PI;
            double perimeter = 2 * r * Math.PI;
            Console.WriteLine($"<calculated area> {area:f2}");
            Console.WriteLine($"<calculated perimeter> {perimeter:f2}");
        }
    }
}
