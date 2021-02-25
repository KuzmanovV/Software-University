using System;

namespace Exam903
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Баскетболни кецове – цената им е 40 % по - малка от таксата за една година
            //•	Баскетболен екип – цената му е 20 % по - евтина от тази на кецовете
            //•	Баскетболна топка – цената ѝ е 1 / 4 от цената на баскетболния екип
            //•	Баскетболни аксесоари – цената им е 1 / 5 от цената на баскетболната топка
            //От конзолата се четe 1 ред:
            //•	Годишната такса за тренировки по баскетбол – цяло число в интервала[0… 999]

            int annual = int.Parse(Console.ReadLine());

            double boots = annual * .6;
            double cloth = boots * .8;
            double ball = cloth * .25;
            double acc = ball * .2;

            Console.WriteLine($"{annual + boots + cloth + ball + acc:f2}");


        }
    }
}
