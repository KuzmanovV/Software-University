using System;

namespace _2Party
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Между 10(вкл.) и 15(вкл.) човека-> 15 % отстъпка от куверта за един човек
            //•	Между 15 и 20(вкл.) човека-> 20 % отстъпка от куверта за един човек
            //•	Над 20 човека-> 25 % отстъпка от куверта за един човек
            //Деси трябва да предвиди и закупуването на торта за партито.Цената на тортата е 10 % от бюджета на Деси.
            //Напишете програма, която изчислява дали бюджетът на Деси ще и е достатъчен за партито.

            int guests = int.Parse(Console.ReadLine());
            double price = double.Parse(Console.ReadLine());
            double budget = double.Parse(Console.ReadLine());

            if (guests>=10 && guests<=15)
            {
                price *= .85;
            }
            else if (guests>15 && guests<=20)
            {
                price *= .8;
            }
            else if (guests>20)
            {
                price *=.75;
            }

            double expences = price * guests + .1 * budget;
            string output = "";

            if (budget >= expences)
            {
                output = $"It is party time! {budget-expences:f2} leva left.";
            }
            else
            {
                output = $"No party! {expences-budget:f2} leva needed.";
            }

            Console.WriteLine(output);


//На конзолата да се отпечата един ред:
//•	Ако бюджетът  е достатъчен:
//o   ""
//•	Ако бюджетът не е достатъчен:
//            o   ""
//Резултатът да бъде форматиран до втория знак след десетичната запетая.

        }
    }
}
