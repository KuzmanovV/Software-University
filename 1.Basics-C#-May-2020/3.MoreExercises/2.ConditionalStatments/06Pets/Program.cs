using System;

namespace _06Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            //Първи ред – брой дни – цяло число в интервал[1…5000]
            //Втори ред – оставена храна в килограми – цяло число в интервал[0…100000]
            //Трети ред – храна на ден за кучето в килограми – реално число в интервал[0.00…100.00]
            //Четвърти ред – храна на ден за котката в килограми– реално число в интервал[0.00…100.00]
            //Пети ред – храна на ден за костенурката в грамове – реално число в интервал[0.00…10000.00]
            int days = int.Parse(Console.ReadLine());
            int foodLeft = int.Parse(Console.ReadLine());
            double dogsFoodDay = double.Parse(Console.ReadLine());
            double catsFoodDay = double.Parse(Console.ReadLine());
            double turtlesFoodDay = double.Parse(Console.ReadLine());//in gr!
            double foodNeeded = days * (dogsFoodDay + catsFoodDay + turtlesFoodDay / 1000);
            if (foodLeft>=foodNeeded)
            {
                Console.WriteLine($"{Math.Floor(foodLeft-foodNeeded)} kilos of food left.");
            }
            else
            {
                Console.WriteLine($"{Math.Ceiling(foodNeeded-foodLeft)} more kilos of food are needed.");
            }
        }
    }
}
