using System;

namespace _09Volley
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Първият ред съдържа думата "leap" (високосна година) или "normal" (невисокосна).
            Вторият ред съдържа цялото число p – брой празници в годината (които не са събота и неделя).
            Третият ред съдържа цялото число h – брой уикенди, в които Влади си пътува до родния град.*/
            string year = Console.ReadLine();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double plays = ((48 - h) * 3 / 4.0 )+ h + (p * 2 / 3.0);
            if (year == "leap")
            {
                plays *= 1.15;
            }
            Console.WriteLine(Math.Floor(plays));
        }
    }
}
