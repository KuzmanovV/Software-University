using System;

namespace MoreExc2___Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string output = "";
            int number = 0;
            bool isNumber = true;

            if (input == "true" || input == "false" )
            {
                output = "Boolean";
            }
            else
            {
                output = TryParse(input, out int result);
            }
            
            Console.WriteLine(number);
        }
    }
}
