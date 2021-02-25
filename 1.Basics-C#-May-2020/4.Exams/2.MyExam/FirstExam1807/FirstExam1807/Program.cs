using System;

namespace FirstExam1807
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1.Име на авиокомпанията -текст
            //2.Брой билети за   възрастни – цяло число в диапазона[1…400]
            //3.Брой детски билети – цяло число в диапазона[25…120]
            //4.Нетна цена на билет за възрастен – реално число в диапазона[100.0…1600.0]
            //5.Цената на такса обслужване - реално число в диапазона[10.0…50.0]

            string name = Console.ReadLine();
            int grownTickets = int.Parse(Console.ReadLine());
            int childrenTickets = int.Parse(Console.ReadLine());
            double grownTicketPr = double.Parse(Console.ReadLine());
            double tax = double.Parse(Console.ReadLine());

            double childrenTicketPr = grownTicketPr * .3;
            double profit = .2 * (grownTickets * (grownTicketPr+tax) + childrenTickets * (childrenTicketPr+tax));

            Console.WriteLine($"The profit of your agency from {name} tickets is {profit:f2} lv.");

//            •	""
//Цената на печалбата да бъде форматирана до втората цифра след десетичния знак.

        }
    }
}
