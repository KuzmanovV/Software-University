using System;

namespace Aqua
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Процент  – реално число в интервала[0.000 … 100.000]
            //ИзходДа се отпечата на конзолата едно число: литрите вода, които ще събира аквариума.
            //Един литър вода се равнява на един кубичен дециметър / 1л = 1 дм3 /.
            int longth = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine())/100;
            double volume = longth * width * height * 0.001;
            double litresWater = volume * (1 - percent);
            Console.WriteLine(litresWater);
        }
    }
}
