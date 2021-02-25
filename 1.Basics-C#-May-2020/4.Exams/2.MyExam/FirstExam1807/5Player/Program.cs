using System;

namespace _5Player
{
    class Program
    {
        static void Main(string[] args)
        {
            string player = Console.ReadLine();
            int maxRes = 0;
            string best = "";

            while (player!="END")
            {
                int goals = int.Parse(Console.ReadLine());

                if (goals>maxRes)
                {
                    maxRes = goals;
                    best = player;
                }

                if (goals>=10)
                {
                    break;
                }

                player = Console.ReadLine();
            }

            Console.WriteLine($"{best} is the best player!");

            if (maxRes>=3)
            {
                Console.WriteLine($"He has scored {maxRes} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {maxRes} goals.");
            }

        }
    }
}
