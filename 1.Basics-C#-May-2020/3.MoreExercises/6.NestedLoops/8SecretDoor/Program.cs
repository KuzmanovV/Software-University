using System;

namespace _8SecretDoor
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	Горната граница на стотиците -цяло число в диапазона(1 - 9)
            //•	Горната граница на десетиците -цяло число в диапазона(1 - 9)
            //•	Горната граница на единиците -цяло число в диапазона(1 - 9)

            //            •	Цифрата на единиците и цифрата на стотиците трябва да бъде четна
            //•	Цифрата на десетиците да бъде просто число в диапазона(2...7).

            int limitHundreds = int.Parse(Console.ReadLine());
            int limitDecs = int.Parse(Console.ReadLine());
            int limitOnes = int.Parse(Console.ReadLine());

            for (int i = 1; i <= limitHundreds; i++)
            {
                for (int j = 1; j <= limitDecs; j++)
                {
                    for (int k = 1; k <= limitOnes; k++)
                    {
                        if (i%2==0 && k%2==0)
                        {
                            if (j==2 || j==3 || j==5 || j==7)
                            {
                                Console.WriteLine($"{i} {j} {k}");
                            }
                        }
                    }
                }
            }
        }
    }
}
