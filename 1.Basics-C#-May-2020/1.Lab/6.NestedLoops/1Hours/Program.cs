using System;

namespace _1Hours
{
    class Program
    {
        static void Main(string[] args)
        {
            int hour = 0;
            int minut = 0;

            while (hour<24)
            {
                while (minut<60)
                {
                    Console.WriteLine($"{hour}:{minut}");
                    minut++;
                }
                minut = 0;
                hour++;
            }
        }
    }
}
