using System;

namespace Deposit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Депозирана сума – реално число в интервала[100.00 … 10000.00];
            double deposite = double.Parse(Console.ReadLine());
            //Срок на депозита(в месеци) – цяло число в интервала[1…12];
            int period = int.Parse(Console.ReadLine());
            //Годишен лихвен процент – реално число в интервала[0.00 …100.00];
            double interest = double.Parse(Console.ReadLine());
            //изчисляваме натрупаната лихва: 200 * 5.7 % = 11.4лв.
            double annInterest = interest * deposite / 100;
            // изчисляваме лихвата за 1 месец: 11.4лв./ 12 месеца = 0.95лв
            double monthInterest = annInterest / 12;
            // общата сума е 200лв депозит +(3(срок на депозита) * 0.95 лв)
            Console.WriteLine(monthInterest * period + deposite);
        }
    }
}
