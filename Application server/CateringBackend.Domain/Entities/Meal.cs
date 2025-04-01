using System;
using System.Collections.Generic;

namespace CateringBackend.Domain.Entities
{
    public class Meal
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public string Allergens { get; set; }
        public int Calories { get; set; }
        public bool IsVegan { get; set; }
        public bool IsAvailable { get; set; }
        public HashSet<Diet> Diets { get; set; }

        public Meal()
        {
            Diets = new HashSet<Diet>();
        }

        public static Meal Create(string name, string ingredients, string allergens, int calories, bool isVegan)
        {
            return new()
            {
                Name = name,
                Ingredients = ingredients,
                Allergens = allergens,
                Calories = calories,
                IsVegan = isVegan,
                IsAvailable = true
            };
        }

        public void MakeUnavailable()
        {
            IsAvailable = false;
        }
    }
}
