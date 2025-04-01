using System;
using CateringBackend.Domain.Entities;

namespace CateringBackend.Meals
{
    public record MealSearchResultDTO
    {
        public Guid MealId { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public bool Vegan { get; set; }

        public MealSearchResultDTO(Meal meal)
        {
            MealId = meal.Id;
            Name = meal.Name;
            Calories = meal.Calories;
            Vegan = meal.IsVegan;
        }
    }
}
