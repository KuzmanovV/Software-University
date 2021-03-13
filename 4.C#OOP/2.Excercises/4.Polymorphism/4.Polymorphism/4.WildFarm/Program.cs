using System;
using System.Collections.Generic;
using _4.WildFarm.Abstract;
using _4.WildFarm.Models;

namespace _4.WildFarm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            while (true)
            {
                string animalInput = Console.ReadLine();
                if (animalInput == "End")
                {
                    break;
                }

                var animalParts = animalInput.Split();

                var foodParts = Console.ReadLine().Split();
                Food food = CreateFood(foodParts);

                Animal animal = CreateAnimal(animalParts);
                animals.Add(animal);
                Console.WriteLine(animal.Sound());
                try
                {
                    animal.Eat(food);
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }

        private static Food CreateFood(string[] foodParts)
        {
            var foodType = foodParts[0];
            var quantity = int.Parse(foodParts[1]);
            Food food = null;
            
            switch (foodType)
            {
                case nameof(Fruit):
                    food = new Fruit(quantity);
                    break;
                case nameof(Meat):
                    food = new Meat(quantity);
                    break;
                case nameof(Seeds):
                    food = new Seeds(quantity);
                    break;
                case nameof(Vegetable):
                    food = new Vegetable(quantity);
                    break;
            }
         
            return food;
        }

        private static Animal CreateAnimal(string[] animalParts)
        {
            string type = animalParts[0];
            string name = animalParts[1];
            double weight = double.Parse(animalParts[2]);

            Animal animal = null;

            switch (type)
            {
                case nameof(Cat):
                    var livingRegion = animalParts[3];
                    var breed = animalParts[4];
                    animal = new Cat(name, weight, livingRegion, breed);
                    break;
                case nameof(Tiger):
                    livingRegion = animalParts[3];
                    breed = animalParts[4];
                    animal = new Tiger(name, weight, livingRegion, breed);
                    break;
                case nameof(Owl):
                    double wingSize = double.Parse(animalParts[3]);
                    animal = new Owl(name, weight, wingSize);
                    break;
                case nameof(Hen):
                    wingSize = double.Parse(animalParts[3]);
                    animal = new Hen(name, weight, wingSize);
                    break;
                case nameof(Dog):
                    livingRegion = animalParts[3];
                    animal = new Dog(name, weight, livingRegion);
                    break;
                case nameof(Mouse):
                    livingRegion = animalParts[3];
                    animal = new Mouse(name, weight, livingRegion);
                    break;
            }

            return animal;
        }
    }
}

