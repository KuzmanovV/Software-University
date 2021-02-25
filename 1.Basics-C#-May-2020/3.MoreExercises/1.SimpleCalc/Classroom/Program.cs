using System;

namespace Classroom
{
    class Program
    {
        static void Main(string[] args)
        {
            //дължина
            double w = double.Parse(Console.ReadLine());
            int wInCm = (int)Math.Round(w * 100);
           
            //ширина
            double h = double.Parse(Console.ReadLine());
             int hInCm = (int)Math.Round(h * 100);
            double rows = wInCm / 120;
            double columns = (hInCm - 100) / 70;
            Console.WriteLine(columns * rows - 3);
            
        }
    }
}
