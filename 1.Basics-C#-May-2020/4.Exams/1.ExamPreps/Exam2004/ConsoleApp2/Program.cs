using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Първи ред -дестинация - текст с възможности"France", "" или ""
            //•	Втори ред -дати, през които си е резервирала екскурзията -текст  с възможности , 
            // или 
            //•	Трети ред -брой нощувки - цяло число в интервала[1… 100]

            string destination = Console.ReadLine();
            string period = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());

            double pr = 0;

            switch (destination)
            {
                case "France":
                    switch (period)
                    {
                        case "21-23": pr = 30; break;
                        case "24-27": pr = 35; break;
                        case "28-31": pr = 40; break;
                    }break;
                case "Italy":
                    switch (period)
                    {
                        case "21-23": pr = 28; break;
                        case "24-27": pr = 32; break;
                        case "28-31": pr = 39; break;
                    }break;
                case "Germany":
                    switch (period)
                    {
                        case "21-23": pr = 32; break;
                        case "24-27": pr = 37; break;
                        case "28-31": pr = 43; break;
                    }break;
            }

            Console.WriteLine($"Easter trip to {destination} : {pr*days:f2} leva.");

        }
    }
}
