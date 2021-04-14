using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CocktailParty
{
    public class Cocktail
    {
        private List<Ingredient> Ingredients;
        public Cocktail(string name, int capacity, int maxAlcoholLevel)
        {
            Name = name;
            Capacity = capacity;
            MaxAlcoholLevel = maxAlcoholLevel;
            Ingredients = new List<Ingredient>();
        }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public int MaxAlcoholLevel { get; set; }
        public int CurrentAlcoholLevel => Ingredients.Sum(i => i.Alcohol);

        public void Add(Ingredient ingredient)
        {
            if (Ingredients.Count<Capacity 
                && Ingredients.Sum(i=>i.Alcohol)+ingredient.Alcohol<=MaxAlcoholLevel
                && !Ingredients.Any(i=>i.Name==ingredient.Name))
            {
                Ingredients.Add(ingredient);
            }
        }

        public bool Remove(string name)
        {
                Ingredient ingredientToRemove = Ingredients.FirstOrDefault(i=>i.Name==name);

                if (ingredientToRemove==null)
                {
                    return false;
                }

                Ingredients.Remove(ingredientToRemove);
                return true;
        }

        public Ingredient FindIngredient(string name)
        {
            return Ingredients.FirstOrDefault(i => i.Name == name);
        }

        public Ingredient GetMostAlcoholicIngredient()
        {
            return Ingredients.OrderByDescending(i => i.Alcohol).FirstOrDefault();
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Cocktail: {Name} - Current Alcohol Level: {CurrentAlcoholLevel}");

            foreach (var ingr in Ingredients)
            {
                result.AppendLine(ingr.ToString().TrimEnd());
            }

            return result.ToString().TrimEnd();
        }
    }
}