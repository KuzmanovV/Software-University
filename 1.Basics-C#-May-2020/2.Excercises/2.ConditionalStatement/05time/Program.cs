using System;

namespace _05time
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int mins = int.Parse(Console.ReadLine());
            mins += 15;
            if (mins>=60)
            {
                hours += 1;
                mins = mins - 60;
            }
            if (hours>23)
            {
                hours = 0;
            }
            if (mins<10)
            {
                Console.WriteLine($"{hours}:0{mins}");
            }
            else
            {
                Console.WriteLine($"{hours}:{mins}");
            }
        }
    }
}
