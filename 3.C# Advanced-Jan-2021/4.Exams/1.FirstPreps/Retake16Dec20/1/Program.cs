using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquids = new Queue<int>(Console.ReadLine().Split().Select(int.Parse));
            Stack<int> ingredientrs = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));

            int mixture = 0;
            int breads = 0;
            int cakes = 0;
            int fruitPies = 0;
            int pastrys = 0;
            bool rightMixture = true;
            int currentIngredient = 0;
            while (liquids.Count > 0 && ingredientrs.Count > 0)
            {
                if (rightMixture)
                {
                    currentIngredient = ingredientrs.Pop();
                }
                mixture = liquids.Dequeue() + currentIngredient;

                switch (mixture)
                {
                    case 25:
                        breads++;
                        rightMixture = true;
                        break;
                    case 50:
                        cakes++;
                        rightMixture = true;
                        break;
                    case 100:
                        fruitPies++;
                        rightMixture = true;
                        break;
                    case 75:
                        pastrys++;
                        rightMixture = true;
                        break;
                    default:
                        currentIngredient += 3;
                        rightMixture = false;
                        break;
                }
            }

            if (!rightMixture)
            {
                ingredientrs.Push(currentIngredient);
            }

            //Output
            if (breads >= 1 && cakes >= 1 && fruitPies >= 1 && pastrys >= 1)
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquids.Count == 0)
            {
                Console.WriteLine("Liquids left: none");
            }
            else
            {
                Console.Write($"Liquids left: ");
                if (liquids.Count != 1)
                {
                    while (liquids.Count > 1)
                    {
                        Console.Write(liquids.Dequeue());
                        Console.Write(", ");
                    }
                
                    Console.WriteLine(liquids.Dequeue());
                }
                else
                {
                    Console.WriteLine(liquids.Dequeue());
                }

            }

            if (ingredientrs.Count == 0)
            {
                Console.WriteLine("Ingredients left: none");
            }
            else
            {
                Console.Write($"Ingredients left: ");

                if (ingredientrs.Count == 1)
                {
                    Console.WriteLine(ingredientrs.Pop());
                }
                else
                {
                    while (ingredientrs.Count > 1)
                    {
                        Console.Write(ingredientrs.Pop());
                        Console.Write(", ");
                    }

                    Console.WriteLine(ingredientrs.Pop());
                }
            }

            Console.WriteLine($"Bread: {breads}");
            Console.WriteLine($"Cake: {cakes}");
            Console.WriteLine($"Fruit Pie: {fruitPies}");
            Console.WriteLine($"Pastry: {pastrys}");
        }
    }
}
