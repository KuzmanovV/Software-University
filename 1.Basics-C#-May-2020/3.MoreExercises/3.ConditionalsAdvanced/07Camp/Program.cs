using System;
using System.Text.RegularExpressions;
using System.Xml.Schema;

namespace _07Camp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Сезонът – текст - “Winter”, “Spring” или “Summer”;
            Видът на групата – текст - “boys”, “girls” или “mixed”;
            Брой на учениците – цяло число в интервала [1 … 10000];
            Брой на нощувките – цяло число в интервала [1 … 100].*/
            string season = Console.ReadLine();
            string group = Console.ReadLine();
            int scholars = int.Parse(Console.ReadLine());
            int nights = int.Parse(Console.ReadLine());

            string sport = "";
            double total = 0;

            switch (season)
            {
                case "Winter":
                    if (group=="girls")
                    {
                    sport = "Gymnastics"; total = scholars*nights * 9.6;
                    }
                    else if (group=="boys")
                    {
                    sport = "Judo"; total = scholars * nights * 9.6;
                    }
                    else
                    {
                    sport = "Ski"; total = scholars * nights * 10;
                    }break;
                case "Spring":
                    if (group=="girls")
                    {
                    sport = "Athletics"; total = scholars * nights * 7.2;
                    }
                    else if (group=="boys")
                    {
                    sport = "Tennis"; total = scholars * nights * 7.2;
                    }
                    else
                    {
                    sport = "Cycling"; total = scholars * nights * 9.5;
                    }break;
                case "Summer":
                    if (group=="girls")
                    {
                    sport = "Volleyball"; total = scholars * nights * 15;
                    }
                    else if (group=="boys")
                    {
                    sport = "Football"; total = scholars * nights * 15;
                    }
                    else
                    {
                    sport = "Swimming"; total = scholars * nights * 20;
                    }break;
            }
            if (scholars<20 && scholars>=10)
            {
                total *= .95;
            }
            else if (scholars<50 && scholars>=20)
            {
                total *= .85;
            }
            else if (scholars>=50)
            {
                total *= .5;
            }
            Console.WriteLine($"{sport} {total:f2} lv.");
        }
    }
}
