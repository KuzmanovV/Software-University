using System;

namespace _03NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            // Вид цветя -текст с възможности -"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            //Брой цветя -цяло число в интервала[10…1000]
            //Бюджет - цяло число в интервала[50…2500]
            string flowers = Console.ReadLine();
            int numberFl = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double total = 0.0;
            //"Roses", "Dahlias", "Tulips", "Narcissus", "Gladiolus"
            switch (flowers)
            {
                case "Roses":
                     total = numberFl * 5;
                    if (numberFl>80)
                    {
                       total *=0.9;
                    }
                    break; 
                case "Dahlias":
                     total = numberFl * 3.8;
                    if (numberFl>90)
                    {
                       total *=0.85;
                    }
                    break;
                     case "Tulips":
                     total = numberFl * 2.8;
                    if (numberFl>80)
                    {
                       total *=0.85;
                    }
                    break;
                     case "Narcissus":
                     total = numberFl * 3;
                    if (numberFl<120)
                    {
                       total *=1.15;
                    }
                    break;
                     case "Gladiolus":
                     total = numberFl * 2.5;
                    if (numberFl<80)
                    {
                       total *=1.2;
                    }
                    break;
            }
            string output = "";
            if (total<=budget)
            {
  output = $"Hey, you have a great garden with {numberFl} {flowers} and {budget - total:f2} leva left.";
            }
            else
            {
                output = $"Not enough money, you need {total - budget:f2} leva more.";
            }
            Console.WriteLine(output);
        }
    }
}
