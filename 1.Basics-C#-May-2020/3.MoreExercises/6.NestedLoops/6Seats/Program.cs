using System;

namespace _6Seats
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Последния сектор от секторите -символ(B - Z)
            //•	Броят на редовете в първия сектор -цяло число(1 - 100)
            //•	Броят на местата на нечетен ред -цяло число(1 - 24)

            char lastSection = char.Parse(Console.ReadLine());
            int rowsA = int.Parse(Console.ReadLine());
            int placesOddRow = int.Parse(Console.ReadLine());
            int counter = 0;

            for (char i = 'A'; i <= lastSection; i++)
            {
                for (int j = 1; j <= rowsA; j++)
                {
                    if (j%2==0)
                    {
                        placesOddRow += 2;
                    }

                    int counterPlacesEachRow = 0;

                    for (char k = 'a'; k <= 'z'; k++)
                    {
                        if (counterPlacesEachRow>=placesOddRow)
                        {
                            break;
                        }
                        
                        Console.WriteLine($"{i}{j}{k}");
                        counter++;
                        counterPlacesEachRow++;
                    }

                    if (j%2==0)
                    {
                        placesOddRow -= 2;
                    }
                }

                rowsA++;
            }

            Console.WriteLine(counter);
//            Накрая трябва да отпечата броя на всички места.
        }
    }
}
