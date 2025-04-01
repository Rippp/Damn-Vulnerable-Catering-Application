using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamnVulnerableCateringApplication.DataObjects
{
    public class Meal
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Calories { get; set; }
        public bool IsVegan { get; set; }
        public Meal() { }
        public Meal(MealDTO mealDTO)
        {
            this.Id = mealDTO.id;
            this.Name = mealDTO.name;
            this.Calories = mealDTO.calories;
            this.IsVegan = mealDTO.isVegan;
        }

        public ListViewItem ConvertToListViewItem()
        {
            return new ListViewItem(new[] { Name, Calories.ToString(), Id.ToString() });
        }
    }

    public class MealDTO
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public int calories { get; set; }
        public bool isVegan { get; set; }
        public MealDTO() { }
    }

    public class MealDetails
    {
        public Guid Id { get; set; }
        public string name { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> Allergens { get; set; }
        public int Calories { get; set; }
        public bool IsVegan { get; set; }
        public MealDetails() { }
        public MealDetails(MealDetailsDTO mealDetailsDTO)
        {
            this.Id = mealDetailsDTO.mealId;
            this.name = mealDetailsDTO.name;
            this.Ingredients = mealDetailsDTO.ingredientList.ToList<string>();
            this.Allergens = mealDetailsDTO.allergenList.ToList<string>();
            this.Calories = mealDetailsDTO.calories;
            this.IsVegan = mealDetailsDTO.vegan;
        }
    }

    public class MealDetailsDTO
    {
        public Guid mealId { get; set; }
        public string name { get; set; }
        public string[] ingredientList { get; set; }
        public string[] allergenList { get; set; }
        public int calories { get; set; }
        public bool vegan { get; set; }
        public MealDetailsDTO() { }
    }
}
