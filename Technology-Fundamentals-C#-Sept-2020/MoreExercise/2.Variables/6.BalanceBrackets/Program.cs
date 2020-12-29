using System;

namespace _6.BalanceBrackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());

            int open = 0;
            int closed = 0;

            for (int i = 0; i < lines; i++)
            {
                string random = Console.ReadLine();

                if (random == "(")
                {
                    open++;
                }
                else
                {
                    if (random == ")")
                    {
                        closed++;
                        
                        if (open != closed)
                        {
                            Console.WriteLine("UNBALANCED");
                            return;
                        }
                       
                    }
                }

               
            }

            if (open == closed)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }


        }
    }
}
