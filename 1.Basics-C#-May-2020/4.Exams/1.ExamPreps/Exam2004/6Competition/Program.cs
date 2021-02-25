using System;

namespace _6Competition
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Първоначално от конзолата се прочита броя на козунаците – цяло число в интервала[1… 100]

            int breads = int.Parse(Console.ReadLine());
            int numGrade = 0;
            int maxGrade = 0;
            int totalGrade = 0;
            string number1 = "";

            for (int i = 1; i <= breads; i++)
            {
                string name = Console.ReadLine();
                string grade = Console.ReadLine();

                while (grade!="Stop")
                {
                    numGrade = int.Parse(grade);
                    totalGrade += numGrade;
                    if (totalGrade>maxGrade)
                    {
                        maxGrade = totalGrade;
                        
                    }
                    grade = Console.ReadLine();
                }
                
                Console.WriteLine($"{name} has {totalGrade} points.");

                if (maxGrade==totalGrade)
                {
                    Console.WriteLine($"{name} is the new number 1!");
                    number1 = name;
                }

                totalGrade = 0;
            }

            Console.WriteLine($"{number1} won competition with {maxGrade} points!");


//След получаване на командата "Stop" се печата един ред:
//•	
//Ако след командата "Stop", пекарят е с най-много точки до момента, да се отпечата допълнителен ред:
//•	
//След дегустация на всички козунаци, да се отпечата един ред:
//•	

        }
    }
}
