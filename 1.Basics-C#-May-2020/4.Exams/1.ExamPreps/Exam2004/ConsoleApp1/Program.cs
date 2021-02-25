using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Един козунак струва 4лв.
            //•	Едно яйце струва 0.45лв.
            
            int guests = int.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            double eggsTotal = .45 * guests * 2;
            double breadTotal = 4 * Math.Ceiling(guests / 3.0);
            double total = eggsTotal + breadTotal;

            if (total<=budget)
            {
                Console.WriteLine($"Lyubo bought {guests / 3} Easter bread and {guests * 2} eggs.");
                Console.WriteLine($"He has {budget-total:f2} lv. left.");
            }
            else
            {
                Console.WriteLine($"Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {total-budget:f2} lv. more.");
            }

//На конзолата да се отпечатат два реда:
//•	Ако бюджетът е достатъчен:
//o   ""
//o   ""
//•	Ако бюджетът НЕ Е достатъчен:
//            o   ""
//o   ""
//Парите да бъдат форматирани до втората цифра след десетичния знак.

        }
    }
}
