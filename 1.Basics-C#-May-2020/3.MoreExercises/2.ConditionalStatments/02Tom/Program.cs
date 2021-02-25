using System;

namespace _02Tom
{
    class Program
    {
        static void Main(string[] args)
        {
            int holydays = int.Parse(Console.ReadLine());
            int wdPlay = (365-holydays)*63;
            int hdPlay = holydays*127;
            int play = wdPlay + hdPlay;
            int h = (30000-play) / 60;
            double m = (30000-play) % 60;
            if (play<=30000)
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine($"{h} hours and {m} minutes less for play");
            }
            else
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine($"{Math.Abs(h)} hours and {Math.Abs(m)} minutes more for play");
            }
        }
    }
}
