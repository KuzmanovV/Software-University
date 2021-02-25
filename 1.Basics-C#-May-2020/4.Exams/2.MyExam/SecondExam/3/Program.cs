using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Порода на котката  –  , "", "", "", "" или ""
            //•	Пол на котката  – символ –  'm' или 'f'

            string cat = Console.ReadLine();
            string gender = Console.ReadLine();
            double years = 0;
            bool invalid = false;

            switch (cat)
            {
                case "British Shorthair": years = 13; break;
                case "Siamese": years = 15; break;
                case "Persian": years = 14; break;
                case "Ragdoll": years = 16; break;
                case "American Shorthair": years = 12; break;
                case "Siberian": years = 11; break;
                default: Console.WriteLine($"{cat} is invalid cat!"); invalid = true; break;
            }
            
            if (gender=="f")
                    {
                years += 1;
                    }

            if (!invalid)
            {
                Console.WriteLine($"{Math.Floor(years*12/6)} cat months");
            }
            

            //Изход:
            //            Да се отпечата на конзолата:
            //            { котешки месецa}
            //            cat months
            //Където резултатът е закръглен до най-близкото цяло число надолу.

        }
    }
}
