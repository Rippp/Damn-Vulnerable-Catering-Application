using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CateringBackend.Domain.Entities;

namespace CateringBackend.Domain.Utilities
{
    public class MealsAndDietsSeedDataProvider
    {
        public List<Diet> DietsToSeed { get; private set; } = new List<Diet>(); 
        public List<Meal> MealsToSeed { get; private set; } = new List<Meal>();

        public MealsAndDietsSeedDataProvider()
        {
            AddVeganDiet();
            AddPremiumChefDiet();
            AddStandardDiet();
            AddSportDiet();
        }

        private void AddVeganDiet()
        {
            var m1 = Meal.Create(
                name: "Sunflower aubergine paste with sourdough rye bread and radishes",
                ingredients: "sunflower, aubergine, rye bread, radish, rice",
                allergens: "cereals with gluten",
                384,
                true);

            var m2 = Meal.Create(
                name: "Chia bird's milk with peach jelly and almond flakes",
                ingredients: "bird's milk, chia, peach jelly, almond flakes",
                allergens: "nuts",
                238,
                true);

            var m3 = Meal.Create(
                name: "Curry with red beans, yams and vegetables with brown rice",
                ingredients: @"Curry with yam potatoes and vegetables, Coconut milk, Water, Potatoes, Yams, White onions, Sugar snap peas, Spinach, Canola oil, Ginger, Garlic, Chili peppers, Red beans, Coriander, Brown rice",
                allergens: "milk and related products",
                847,
                true);

            var m4 = Meal.Create(
                name: "Coconut millet cookies",
                ingredients: @"Buckwheat, Dates, dried, Coconut, Almonds, Coconut oil",
                allergens: "Nuts, Sesame seeds and derived products",
                384,
                true);

            var m5 = Meal.Create(
                name: "Ratatouille with green lentils",
                ingredients: @"Buckwheat, Dates, dried, Coconut, Almonds, Coconut oil",
                allergens: "Parsley, parsley, Whole peeled tomatoes, Red pepper, Aubergine, Courgette, White onion, Olive oil, Garlic, Green lentils",
                690,
                true);

            var dietMeals = new List<Meal> {m1, m2, m3, m4, m5};

            var description = "A vegan diet is one that does not contain animal products, i.e. meat (including fish and seafood), dairy, eggs, etc. Although it may initially appear difficult and deficient, the World Health Organisation clearly states that, when properly balanced, it is healthy and safe for people at every stage of life, including pregnant women, young children, adolescents and athletes, and its growing popularity means that buying vegan products today is no longer a challenge.\n";

            var diet1 = Diet.Create(
                title: "Vegan Diet - Basic",
                description: description,
                price: 59,
                meals: new List<Meal> { m1, m3, m5 });

            var diet2 = Diet.Create(
                title: "Vegan Diet - Basic with afternoon snack",
                description: description,
                price: 59,
                meals: new List<Meal> { m1, m3, m4, m5 });

            var diet3 = Diet.Create(
                title: "Vegan Diet - Basic with second breakfast",
                description: description,
                price: 59,
                meals: new List<Meal> { m1, m2, m3, m5 });

            var diet4 = Diet.Create(
                title: "Vegan Diet - Premium",
                description: description,
                price: 59,
                meals: new List<Meal> { m1, m2, m3, m4, m5 });

            var diet5 = Diet.Create(
                title: "Vegan Diet - Breakfast only",
                description: description,
                price: 59,
                meals: new List<Meal> { m1 });

            MealsToSeed.AddRange(dietMeals);
            DietsToSeed.Add(diet1);
            DietsToSeed.Add(diet2);
            DietsToSeed.Add(diet3);
            DietsToSeed.Add(diet4);
            DietsToSeed.Add(diet5);
        }

        private void AddPremiumChefDiet()
        {
            var m1 = Meal.Create(
                name: "French toast made from challah with homemade jam and cheese",
                ingredients: @"Yeast challah, Hen's eggs, Drinking milk, Raspberries, Potato starch, Orange jam, Mint, Cream of 22% fat, Bee honey",
                allergens: "Cereals containing gluten, Eggs and products thereof, Milk and products thereof (including lactose)",
                420,
                false);

            var m2 = Meal.Create(
                name: "Apple and banana racakes with cheese and champagne mousse",
                ingredients: @"Kefir, Wheat flour, Apple, Banana, Hen eggs, Bee honey, Canola oil, Baking powder, Baking soda",
                allergens: "Cereals containing gluten, Eggs and products thereof, Milk and products thereof (including lactose), Sulphur dioxide and sulphites",
                569,
                true);

            var m3 = Meal.Create(
                name: "Halibut in mushroom and pepper sauce with caramelised vegetables",
                ingredients: @"Halibut, Celery, White onion, Lemon juice, 82% butter, Olive oil, Thyme, 18% cream, Shimeji mushrooms, Cognac, Shallots, Fermented pepper, Dry white wine, Garlic, Olive oil, Thyme, Purple potatoes",
                allergens: "Fish and products thereof, Milk and products thereof (including lactose), Nuts",
                835,
                false);


            var m4 = Meal.Create(
                name: "Chocolate mousse with raspberry sauce",
                ingredients: @"White chocolate, Raspberries, Sugar, Cream, Hen eggs",
                allergens: "Eggs and products thereof, Milk and products thereof (including lactose)",
                478,
                false);


            var m5 = Meal.Create(
                name: "Italian-style baked potatoes",
                ingredients: @"Fresh basil, potatoes, cherry tomato, white onion, cheese, parmesan, rapeseed oil, olive oil, garlic, thyme",
                allergens: "Milk and derived products (including lactose)",
                278,
                false);

            var dietMeals = new List<Meal> { m1, m2, m3, m4, m5 };

            var description =
                "High-standard, premium diet which was specifically and carefully crafted by michelin-star chef to proivde maximum levels of satisfaction from eating alongside with a multitude of health benefits";

            var diet1 =  Diet.Create(
                title: "Premium Chef Diet - Basic",
                description: description,
                price: 45,
                meals: new List<Meal> { m1, m3, m5 });

            var diet2 = Diet.Create(
                title: "Premium Chef Diet - Basic with afternoon snack",
                description: description,
                price: 45,
                meals: new List<Meal> { m1, m3, m4, m5 });

            var diet3 = Diet.Create(
                title: "Premium Chef Diet - Basic with second breakfast",
                description: description,
                price: 45,
                meals: new List<Meal> { m1, m2, m3, m5 });

            var diet4 = Diet.Create(
                title: "Premium Chef Diet - Premium",
                description: description,
                price: 45,
                meals: new List<Meal> { m1, m2, m3, m4, m5 });

            MealsToSeed.AddRange(dietMeals);
            DietsToSeed.Add(diet1);
            DietsToSeed.Add(diet2);
            DietsToSeed.Add(diet3);
            DietsToSeed.Add(diet4);
        }

        private void AddStandardDiet()
        {
            var m1 = Meal.Create(
                name: "Mango sticky rice",
                ingredients: "Mango, Bees honey, Coconut milk, Spices, Basmati rice",
                allergens: "",
                420,
                false);

            var m2 = Meal.Create(
                name: "Potato pancake with blue cheese dip with carrots and kohlrabi",
                ingredients: @"Greek yoghurt, Sour cream, Azure cheese, Wine vinegar, Honey, Chives, Kohlrabi, Carrots, Potatoes, Hens' eggs, Cheese, cheddar, Garlic",
                allergens: "Eggs and products thereof, Milk and products thereof (including lactose)",
                682,
                false);

            var m3 = Meal.Create(
                name: "Tuna spaghetti",
                ingredients: @"Whole wheat pasta, Olive oil, Parsley, Cherry tomato, 18% cream, Tuna in its own sauce, Green peppers, Red onion, Canola oil, Spices, Potato starch, Jalapeno pepper",
                allergens: "Cereals containing gluten, Fish and products thereof, Milk and products thereof (including lactose)",
                962,
                false);

            var m4 = Meal.Create(
                name: "Cheesecake with walnut and coffee mousse",
                ingredients: @"Ground cottage cheese, 18% cream, Bee honey, Oat biscuits, Hen eggs, 82% fat butter, Walnuts, Potato starch, Water, Maple syrup, Instant coffee",
                allergens: "Cereals containing gluten, Eggs and derived products",
                382,
                false);

            var m5 = Meal.Create(
                name: "Asian lemon soup with soy noodles",
                ingredients: @"Water, Coconut milk, Sauerkraut, Red pepper, Red onion, Lemon juice, Light soy sauce, Ginger, fresh, Tom Kha paste, Bee honey, Garlic, Canola oil, Chili pepper, Spices, Lemongrass, Fish sauce, Soy noodles",
                allergens: "Soya and products thereof",
                538,
                false);

            var description = @"A meal-box dedicated to people who want to save time on cooking meals for work.

We make sure that the meals are always varied and perfectly balanced, rich in nutrients to give you maximum energy at work.

It consists of: breakfast, lunch and afternoon snack.

With two options to choose from, you can easily replenish the rest of the calories you need at home.";

            var diet1 = Diet.Create(
                title: "Standard Diet - Basic",
                description: description,
                price: 39,
                meals: new List<Meal> { m1, m3, m5 });

            var diet2 = Diet.Create(
                title: "Standard Diet - Basic with afternoon snack",
                description: description,
                price: 49,
                meals: new List<Meal> { m1, m2, m3, m5 });

            var diet3 = Diet.Create(
                title: "Standard Diet - Premium",
                description: description,
                price: 59,
                meals: new List<Meal> { m1, m2, m3, m4, m5 });

            MealsToSeed.AddRange(new List<Meal> { m1, m2, m3, m4, m5 });
            DietsToSeed.Add(diet1);
            DietsToSeed.Add(diet2);
            DietsToSeed.Add(diet3);
        }

        void AddSportDiet()
        {
            var m1 = Meal.Create(
                name: "Sandwich with sunflower aubergine paste and vegetables, Fruit protein shake",
                ingredients: "Wholemeal rye bread, Drinking milk, Pear, apple, redcurrant, gooseberry, Whey protein, Bee honey, Aubergine, Sunflower, seeds, Red onion, Sun-dried tomatoes in oil, Canola oil, Radish, Chives",
                allergens: "Cereals containing gluten, Milk and derived products (including lactose)",
                620,
                false);

            var m2 = Meal.Create(
                name: "Homemade monte dessert",
                ingredients: @"Natural cheese, Honey, Natural cocoa, Vanilla extract, Hazelnuts",
                allergens: "Nuts, Milk and derived products (including lactose)",
                340,
                false);

            var m3 = Meal.Create(
                name: "Curry with turkey, yams and vegetables with brown rice, Cream of green vegetables",
                ingredients: @"Coconut milk, Water, Potatoes, Yams, White onion, Sugar snap peas, Spinach, Canola oil, Ginger, Garlic, Chili pepper, Coriander, Water, Broccoli, Green peas, frozen, White onion, 82% fat butter, Garlic, Spices, Turkey breast meat, Canola oil, Brown rice",
                allergens: "Milk and derived products (including lactose)",
                824,
                false);

            var m4 = Meal.Create(
                name: "Banana cake with jam and tahini, Blueberry smoothie",
                ingredients: @"Banana, Plum jam, Bee honey, Wheat flour, Tahini, Hen eggs, Wheat flour, Wine vinegar, Vanilla extract, Baking soda, Baking powder, Spices, Cinnamon, Apple juice, pressed, Blueberries",
                allergens: "Cereals containing gluten",
                254,
                true);

            var m5 = Meal.Create(
                name: "Moroccan soup with chicken",
                ingredients: @"Lemon, Dates, dried, Chicken breast meat, Canola oil, Sesame, Water, Whole peeled tomatoes, Chickpeas, Carrots, Red lentils, Green lentils, Cinnamon",
                allergens: "Sesame seeds and products thereof, Sulphur dioxide and sulphites",
                523,
                false);

            var dietMeals = new List<Meal> { m1, m2, m3, m4, m5 };

            var description =
                "The Sport Diet is ideal for those with increased energy needs as well as those who are physically active and want to change their eating habits and thus achieve better results.";

            var diet1 = Diet.Create(
                title: "Sport Diet - Basic",
                description: description,
                price: 42,
                meals: new List<Meal> { m1, m3, m5 });

            var diet2 = Diet.Create(
                title: "Sport Diet - Basic with second breakfast",
                description: description,
                price: 49,
                meals: new List<Meal> { m1, m2, m3, m5 });

            var diet3 = Diet.Create(
                title: "Sport Diet - Basic with afternoon snack",
                description: description,
                price: 49,
                meals: new List<Meal> { m1, m3, m4, m5 });

            var diet4 = Diet.Create(
                title: "Sport Diet - Premium",
                description: description,
                price: 59,
                meals: new List<Meal> { m1, m2, m3, m4, m5 });


            MealsToSeed.AddRange(dietMeals);
            DietsToSeed.Add(diet1);
            DietsToSeed.Add(diet2);
            DietsToSeed.Add(diet3);
            DietsToSeed.Add(diet4);
        }
    }
}
