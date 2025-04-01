using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DamnVulnerableCateringApplication.DataObjects
{
    public class Diet
    { 
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Calories { get; set; }
        public bool Vegan { get; set; }

        public Diet() { }
        public Diet(DietDTO dietDTO)
        {
            this.Id = dietDTO.id;
            this.Name = dietDTO.name;
            this.Price = dietDTO.price;
            this.Calories = dietDTO.calories;
            this.Vegan = dietDTO.vegan;
        }

        public ListViewItem ConvertToListViewItem()
        {
            return new ListViewItem(new[] { Name, Calories.ToString(), Price.ToString("0.00"), Vegan ? "Tak" : "Nie", Id.ToString() });
        }
    }

    public class DietDTO
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public decimal price { get; set; }
        public int calories { get; set; }
        public bool vegan { get; set; }

        public DietDTO() { }

        public DietDTO(Diet diet)
        {
            this.id = diet.Id;
            this.name = diet.Name;
            this.price = diet.Price;
            this.calories = diet.Calories;
            this.vegan = diet.Vegan;
        }
    }

    public class DietDetails
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Calories { get; set; }
        public bool Vegan { get; set; }
        public List<Meal> Meals { get; set; }

        public DietDetails() { }
        public DietDetails(DietDetailsDTO dietDetailsDTO)
        {
            this.Name = dietDetailsDTO.name;
            this.Price = dietDetailsDTO.price;
            this.Calories = dietDetailsDTO.calories;
            this.Vegan = dietDetailsDTO.vegan;
            this.Meals = dietDetailsDTO.meals.ConvertAll(x => new Meal(x));
        }
    }

    public class DietDetailsDTO
    {
        public string name { get; set; }
        public decimal price { get; set; }
        public int calories { get; set; }
        public bool vegan { get; set; }
        public List<MealDTO> meals { get; set; }
    }
}
