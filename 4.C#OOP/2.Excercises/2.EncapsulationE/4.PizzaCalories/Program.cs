using System;

namespace _4.PizzaCalories
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                var pizzaName = Console.ReadLine().Split()[1];
                var doughData = Console.ReadLine().Split();

                var flourType = doughData[1];
                var bakingTechnique = doughData[2];
                var weight = int.Parse(doughData[3]);

                Dough dough = new Dough(flourType, bakingTechnique, weight);
                var pizza = new Pizza(pizzaName, dough);

                while (true)
                {
                    var line = Console.ReadLine();
                    if (line == "END")
                    {
                        break;
                    }

                    var parts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                    var topping = new Topping(parts[1], int.Parse(parts[2]));

                    pizza.AddTopping(topping);
                }

                Console.WriteLine($"{pizza.Name} - {pizza.GetCalories():f2} Calories.");
            }
            catch (Exception e)
            when(e is ArgumentException || e is InvalidOperationException)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
