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
            
            while (true)
            {
                string animalInput = Console.ReadLine();
                if (animalInput=="End")
                {
                    break;
                }

                var animalParts = animalInput.Split();
                string type = animalParts[0];
                string name = animalParts[1];
                double weight = double.Parse(animalParts[2]);

                var foodParts = Console.ReadLine().Split();
                var foodType = foodParts[0];
                var foodEaten = int.Parse(foodParts[1]);

                switch (type)
                {
                    case "Cat": 
                        var livingRegion = animalParts[3];
                        var breed = animalParts[4];
                        Cat cat = new Cat(name,weight,foodEaten,livingRegion,breed);
                        break;
                    case "Tiger":
                        livingRegion = animalParts[3];
                        breed = animalParts[4];
                        Tiger tiger = new Tiger(name, weight, foodEaten, livingRegion, breed);
                        break;
                    case "Owl":
                        double  wingSize = double.Parse(animalParts[3]);
                        Owl owl = new Owl(name,weight,foodEaten,wingSize);
                        break;
                }
            }

            
        }
    }
}
