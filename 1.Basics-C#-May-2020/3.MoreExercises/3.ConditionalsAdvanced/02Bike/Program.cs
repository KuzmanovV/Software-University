using System;

namespace _02Bike
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Първият ред – броят младши велосипедисти.Цяло число в интервала[1…100]
 Вторият ред – броят старши велосипедисти.Цяло число в интервала[1… 100]
 Третият ред – вид трасе – "trail", "cross-country", "downhill" или "road"*/
            int juniors = int.Parse(Console.ReadLine());
            int seniors = int.Parse(Console.ReadLine());
            string trace = Console.ReadLine();
            double output = 0;
            switch (trace)
            {
                case "trail": output = juniors * 5.5 + seniors * 7; break;
                case "cross-country": output = juniors * 8 + seniors * 9.5; 
                    if (juniors+seniors>=50)
                    {
                    output *= 0.75;
                    }break;
                case "downhill": output = juniors * 12.25 + seniors * 13.75; break;
                case "road": output = juniors * 20 + seniors * 21.5; break;
            }
            
            output *= 0.95;
            Console.WriteLine($"{output:f2}");
        }
    }
}
