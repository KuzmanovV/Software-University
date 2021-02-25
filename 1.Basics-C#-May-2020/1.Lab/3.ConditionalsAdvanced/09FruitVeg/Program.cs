using System;

namespace _09FruitVeg
{
    class Program
    {
        static void Main(string[] args)
        {
            string smth = Console.ReadLine();
            switch (smth)
            {
                case "banana":
                case "apple":
                case "kiwi":
                case "cherry":
                case "lemon":
                case "grapes": Console.WriteLine("fruit"); break;
                case "tomato":
                case "cucumber":
                case "pepper":
                case "carrot":Console.WriteLine("vegetable"); break;
                default:Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
