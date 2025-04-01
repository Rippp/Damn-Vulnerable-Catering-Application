using System;
using CateringBackend.Domain.Entities;

namespace CateringBackend.Diets
{
    public record DietsSearchResultDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Calories { get; set; }
        public bool Vegan { get; set; }

        public DietsSearchResultDTO(Diet diet)
        {
            Id = diet.Id;
            Name = diet.Title;
            Price = (int)diet.Price;
            Calories = diet.Calories;
            Vegan = diet.IsVegan;
        }
    }
}
