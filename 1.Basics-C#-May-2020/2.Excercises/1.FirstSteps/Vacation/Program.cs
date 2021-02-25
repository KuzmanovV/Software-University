using System;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Брой страници в текущата книга – цяло число в интервала[1…1000];
            int pages = int.Parse(Console.ReadLine());
            //2.Страници, които може да прочита за 1 час – реално число в интервала[1.00…1000.00];
            double speed = double.Parse(Console.ReadLine());
            //3.Броя на дните, за които трябва да прочете книгата – цяло число в интервала[1…1000];
            int days = int.Parse(Console.ReadLine());
            Console.WriteLine(pages / speed / days);
        }
    }
}
