using System;

namespace _4Battle
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1.Брой яйца, които има първият играч -цяло число в интервала[1 … 99]
            //2.Брой яйца, които има вторият играч -цяло число в интервала[1 … 99]
            //След това до получаване на команда  се четe многократно един ред:
            //            3.Победител - текст - "one" или "two"

            int eggsFirst = int.Parse(Console.ReadLine());
            int eggsSecond = int.Parse(Console.ReadLine());
            string winner = Console.ReadLine();

            while (winner!="End of battle")
            {
                if (winner=="one")
                {
                    eggsSecond--;
                }
                else
                {
                    eggsFirst--;
                }

                if (eggsFirst==0)
                {
                    Console.WriteLine($"Player one is out of eggs. Player two has {eggsSecond} eggs left.");
                    break;
                }
                else if (eggsSecond==0)
                {
                    Console.WriteLine($"Player two is out of eggs. Player one has {eggsFirst} eggs left.");
                    break;
                }

                winner = Console.ReadLine();
            }

            if (winner== "End of battle")
            {
                Console.WriteLine($"Player one has {eggsFirst} eggs left.");
                Console.WriteLine($"Player two has {eggsSecond} eggs left.");
            }

//Ако първият играч остане без яйца:
//•	
//Ако вторият играч остане без яйца:
//•	"Player two is out of eggs. Player one has {брой останали яйца на първия играч} eggs left."
//При команда "End of battle" да се отпечатат два реда:
//•	
//•	"Player two has {брой останали яйца на втория играч} eggs left."

        }
    }
}
