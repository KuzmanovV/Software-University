using System;

namespace ForLoop_ME
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double inherited = double.Parse(Console.ReadLine());
            int yearLast = int.Parse(Console.ReadLine());
            string output = "";
            double spend = 0;
            int age = 17;

            for (int i = 1800; i <= yearLast; i++)
            {
                age++;
                if (i%2==0)
                {
                    spend += 12000;
                }
                else
                {
                    spend = spend + 12000 + 50 * age;
                }
                
            }

            if (spend<=inherited)
            {
                output = $"Yes! He will live a carefree life and will have {inherited - spend:f} dollars left.";
            }
            else
            {
                output = $"He will need {spend-inherited:f2} dollars to survive.";
            }

            Console.WriteLine(output);

            /*1 ред. Сумата трябва да е форматирана до два знака след десетичната запетая:
•	Ако парите са достатъчно:
o	"Yes! He will live a carefree life and will have {N} dollars left." – където N са парите, които ще му останат.
•	Ако парите НЕ са достатъчно:
o	"He will need {М} dollars to survive." – където M е сумата, която НЕ достига.*/
        }
    }
}
