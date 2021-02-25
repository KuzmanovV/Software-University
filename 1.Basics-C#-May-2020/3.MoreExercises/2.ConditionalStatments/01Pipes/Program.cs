using System;

namespace MoreExcersConditionalStatm
{
    class Program
    {
        static void Main(string[] args)
        {
            //Първият ред съдържа числото V – Обем на басейна в литри – цяло число в интервала[1…10000].
            //Вторият ред съдържа числото P1 – дебит на първата тръба за час – цяло число в интервала[1…5000].
            //Третият ред съдържа числото P2 – дебит на втората тръба за час– цяло число в интервала[1…5000].
            //Четвъртият ред съдържа числото H – часовете които работникът отсъства – реално число в интервала[1.0…24.00]
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());
            double VP1 = H * P1;
            double VP2 = H * P2;
            double VP12 = VP1 + VP2;
            if (VP12<=V)
            {
                Console.WriteLine($"The pool is {VP12 / V * 100:f2}% full. Pipe 1: {VP1 / VP12*100:f2}%. Pipe 2: {VP2 / VP12*100:f2}%.");
            }
            else
            {
                Console.WriteLine($"For {H} hours the pool overflows with {VP12 - V:f2} liters.");
            }
        }
    }
}
