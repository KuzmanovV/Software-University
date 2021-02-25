using System;

namespace ConditionalExcersises
{
    class Program
    {
        static void Main(string[] args)
        {
int time1 = int.Parse(Console.ReadLine());
int time2 = int.Parse(Console.ReadLine());
int time3 = int.Parse(Console.ReadLine());
            int sum = time1 + time2 + time3;
            int min = sum / 60;
            int sec = sum % 60;
            if (sec<10)
            {
                Console.WriteLine($"{min}:0{sec}");
            }
            else
            {
                Console.WriteLine($"{min}:{sec}");
            }
        }
    }
}
