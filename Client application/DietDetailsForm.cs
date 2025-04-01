using DamnVulnerableCateringApplication.DataObjects;
using ReaLTaiizor.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DamnVulnerableCateringApplication
{
    public partial class DietDetailsForm : MaterialForm
    {
        public DietDetailsForm(Diet diet)
        {
            InitializeComponent();

            DietNameLabel.Text = diet.Name;
            DietKcalLabel.Text = diet.Calories.ToString() + " kcal";
            DietPriceLabel.Text = diet.Price.ToString() + " PLN";
            IsVeganLabel.Text = diet.Vegan ? "Yes" : "No";

            var dietDetails = HTTPHandler.GetDietDetails(diet.Id.ToString());
            foreach (var meal in dietDetails.Meals)
                MealsListView.Items.Add(meal.ConvertToListViewItem());
        }

        private void MealsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MealsListView.SelectedIndices.Count > 0)
            {
                var selectedMealID = MealsListView.SelectedItems[0].SubItems[MealsListView.SelectedItems[0].SubItems.Count - 1].Text;
                var mealDetails = HTTPHandler.GetMealDetails(selectedMealID);

                IngredientsListView.Items.Clear();
                AlergensListView.Items.Clear();

                foreach (var ingredient in mealDetails.Ingredients)
                    IngredientsListView.Items.Add(new ListViewItem(ingredient));

                foreach (var allergen in mealDetails.Allergens)
                    AlergensListView.Items.Add(new ListViewItem(allergen));
            }
        }
    }
}
