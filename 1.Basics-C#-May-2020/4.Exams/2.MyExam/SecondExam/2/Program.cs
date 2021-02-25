using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	На първия ред - размерът на ръкава -реално число в интервала[1…1000]
            //•	На втория ред - размерът на предната част - реално число в интервала[1…1000]
            //•	На третия ред - платът, от който искаме да е ризата -, "Cotton", "Denim", "Twill" или "Flannel"
            //•	На четвъртия ред - дали ще желае вратовръзка – текст с възможности: "Yes", "No"

            double hand = double.Parse(Console.ReadLine());
            double front = double.Parse(Console.ReadLine());
            string material = Console.ReadLine();
            string knot = Console.ReadLine();
            double price = 15;

            double qty = 2 * (hand + front)/100;
            qty *= 1.1;

            switch (material)
            {
                case "Cotton": price = 12; break;
                case "Denim": price = 20; break;
                case "Twill": price = 16; break;
                case "Flannel": price = 11; break;
            }

            double output = price * qty + 10;

            if (knot == "Yes")
            {
                output *= 1.2;
            }

            Console.WriteLine($"The price of the shirt is: {output:f2}lv.");

            //Изход:
            //            Да се отпечата на конзолата един ред:
            //•	""
            //Цената на ризата да се форматира до втория знак след десетичната запетая.

        }
    }
}
