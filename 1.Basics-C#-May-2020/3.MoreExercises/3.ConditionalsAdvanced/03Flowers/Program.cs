using System;

namespace _03Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*На първия ред е броят на закупените хризантеми – цяло число в интервала [0 ... 200]
            На втория ред е броят на закупените рози – цяло число в интервала [0 ... 200]
            На третия ред е броят на закупените лалета – цяло число в интервала [0 ... 200]
            На четвъртия ред е посочен сезона – [Spring, Summer, Аutumn, Winter]
            На петия ред е посочено дали денят е празник – [Y – да / N - не]*/
            int chrysanths = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int tulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holyday = Console.ReadLine();

            double output = 0;

            switch (season)
            {
                case "Spring": output = chrysanths * 2 + roses * 4.1 + tulips * 2.5;
                    if (holyday=="Y")
                    {
                        output *= 1.15;
                    }
                    if (tulips>7)
                    {
                        output *= .95;
                    } break;
                case "Summer": output = chrysanths * 2 + roses * 4.1 + tulips * 2.5;
                    if (holyday=="Y")
                    {
                        output *= 1.15;
                    }break;
                case "Autumn": output = chrysanths * 3.75 + roses * 4.5 + tulips * 4.15;
                    if (holyday=="Y")
                    {
                        output *= 1.15;
                    }break;
                case "Winter": output = chrysanths * 3.75 + roses * 4.5 + tulips * 4.15;
                    if (holyday=="Y")
                    {
                        output *= 1.15;
                    }
                    if (roses >= 10)
                    {
                        output *= .9;
                    }break;
            }
            if (chrysanths+roses+tulips>20)
            {
                output *= .8;
            }

            Console.WriteLine($"{output+2:f2}");
        }
    }
}
