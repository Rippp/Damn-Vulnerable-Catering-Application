using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace CateringBackend.Domain.Entities
{
    public class Diet
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
        public HashSet<Meal> Meals { get; set; }
        public HashSet<Order> Orders { get; set; }
        public int Calories => Meals.Sum(m => m.Calories);
        public bool IsVegan => Meals.All(m => m.IsVegan);
        
        public Diet()
        {
            Meals = new HashSet<Meal>();
            Orders = new HashSet<Order>();
        }

        public static Diet Create(string title, string description, decimal price, IEnumerable<Meal> meals = null)
        {
            var diet = new Diet()
            {
                Title = title,
                Description = description,
                Price = price,
                IsAvailable = true
            };
            if (meals != null)
                diet.Meals = new HashSet<Meal>(meals);

            return diet;
        }

        public void MakeUnavailable()
        {
            IsAvailable = false;
        }
    }
}
