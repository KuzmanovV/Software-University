using System;

namespace _9.Padawan
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double padawans = double.Parse(Console.ReadLine());
            double lightsaberPrice = double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());

            string result = "";

            double expences = Math.Ceiling(padawans * 1.1) * lightsaberPrice +
                                                        padawans * robePrice +
                             (padawans - Math.Floor(padawans / 6)) * beltPrice;

            if (expences <= budget)
            {
                result = $"The money is enough - it would cost {expences:f2}lv.";
            }
            else
            {
                result = $"Ivan Cho will need {expences - budget:f2}lv more.";
            }

            Console.WriteLine(result);
        }
    }
}
