using System;

namespace _07swimming
{
    class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double distance = double.Parse(Console.ReadLine());
            double speed = double.Parse(Console.ReadLine());
            double time = distance * speed;
            double currentSlow = Math.Floor(distance / 15.0)*12.5;
            double currentTime = time+currentSlow;
            if (currentTime < record)
            {
                Console.WriteLine($"Yes, he succeeded! The new world record is {currentTime:f2} seconds.");
            }
            else
            {
                Console.WriteLine($"No, he failed! He was {currentTime - record:f2} seconds slower.");
            }
        }
    }
}
