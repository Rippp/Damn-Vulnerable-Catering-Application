namespace DamnVulnerableCateringApplication
{
    partial class DietDetailsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DietNameLabel = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel2 = new ReaLTaiizor.Controls.MaterialLabel();
            DietKcalLabel = new ReaLTaiizor.Controls.MaterialLabel();
            DietPriceLabel = new ReaLTaiizor.Controls.MaterialLabel();
            materialLabel5 = new ReaLTaiizor.Controls.MaterialLabel();
            MealsListView = new ReaLTaiizor.Controls.MaterialListView();
            MealNameHeader = new ColumnHeader();
            MealCaloriesHeader = new ColumnHeader();
            MealIDHeader = new ColumnHeader();
            materialLabel6 = new ReaLTaiizor.Controls.MaterialLabel();
            IngredientsListView = new ReaLTaiizor.Controls.MaterialListView();
            SkładnikiHeader = new ColumnHeader();
            AlergensListView = new ReaLTaiizor.Controls.MaterialListView();
            AlergensHeader = new ColumnHeader();
            materialLabel3 = new ReaLTaiizor.Controls.MaterialLabel();
            IsVeganLabel = new ReaLTaiizor.Controls.MaterialLabel();
            SuspendLayout();
            // 
            // DietNameLabel
            // 
            DietNameLabel.AutoSize = true;
            DietNameLabel.Depth = 0;
            DietNameLabel.Font = new Font("Roboto", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            DietNameLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H4;
            DietNameLabel.Location = new Point(7, 81);
            DietNameLabel.Margin = new Padding(4, 0, 4, 0);
            DietNameLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            DietNameLabel.Name = "DietNameLabel";
            DietNameLabel.Size = new Size(154, 41);
            DietNameLabel.TabIndex = 33;
            DietNameLabel.Text = "Diet name";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel1.Location = new Point(7, 137);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(62, 19);
            materialLabel1.TabIndex = 34;
            materialLabel1.Text = "Calories:";
            // 
            // materialLabel2
            // 
            materialLabel2.AutoSize = true;
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.Location = new Point(7, 168);
            materialLabel2.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(96, 19);
            materialLabel2.TabIndex = 35;
            materialLabel2.Text = "Price per day:";
            // 
            // DietKcalLabel
            // 
            DietKcalLabel.Depth = 0;
            DietKcalLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            DietKcalLabel.Location = new Point(120, 137);
            DietKcalLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            DietKcalLabel.Name = "DietKcalLabel";
            DietKcalLabel.Size = new Size(100, 19);
            DietKcalLabel.TabIndex = 36;
            DietKcalLabel.Text = "100 kcal";
            DietKcalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DietPriceLabel
            // 
            DietPriceLabel.Depth = 0;
            DietPriceLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            DietPriceLabel.Location = new Point(120, 168);
            DietPriceLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            DietPriceLabel.Name = "DietPriceLabel";
            DietPriceLabel.Size = new Size(100, 19);
            DietPriceLabel.TabIndex = 37;
            DietPriceLabel.Text = "100 PLN";
            DietPriceLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // materialLabel5
            // 
            materialLabel5.AutoSize = true;
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel5.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            materialLabel5.Location = new Point(7, 205);
            materialLabel5.Margin = new Padding(4, 0, 4, 0);
            materialLabel5.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(243, 24);
            materialLabel5.TabIndex = 38;
            materialLabel5.Text = "Meals contained in the diet";
            // 
            // MealsListView
            // 
            MealsListView.AllowColumnReorder = true;
            MealsListView.AutoSizeTable = false;
            MealsListView.BackColor = Color.FromArgb(255, 255, 255);
            MealsListView.BorderStyle = BorderStyle.None;
            MealsListView.Columns.AddRange(new ColumnHeader[] { MealNameHeader, MealCaloriesHeader, MealIDHeader });
            MealsListView.Depth = 0;
            MealsListView.Font = new Font("Microsoft Sans Serif", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            MealsListView.FullRowSelect = true;
            MealsListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            MealsListView.Location = new Point(7, 232);
            MealsListView.Margin = new Padding(4, 3, 4, 3);
            MealsListView.MinimumSize = new Size(250, 200);
            MealsListView.MouseLocation = new Point(-1, -1);
            MealsListView.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            MealsListView.MultiSelect = false;
            MealsListView.Name = "MealsListView";
            MealsListView.OwnerDraw = true;
            MealsListView.RightToLeftLayout = true;
            MealsListView.Size = new Size(605, 323);
            MealsListView.TabIndex = 39;
            MealsListView.UseCompatibleStateImageBehavior = false;
            MealsListView.View = View.Details;
            MealsListView.SelectedIndexChanged += MealsListView_SelectedIndexChanged;
            // 
            // MealNameHeader
            // 
            MealNameHeader.Text = "Name";
            MealNameHeader.Width = 490;
            // 
            // MealCaloriesHeader
            // 
            MealCaloriesHeader.Text = "Calories (kcal)";
            MealCaloriesHeader.TextAlign = HorizontalAlignment.Center;
            MealCaloriesHeader.Width = 128;
            // 
            // MealIDHeader
            // 
            MealIDHeader.Width = 0;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel6.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.H6;
            materialLabel6.Location = new Point(620, 205);
            materialLabel6.Margin = new Padding(4, 0, 4, 0);
            materialLabel6.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(216, 24);
            materialLabel6.TabIndex = 40;
            materialLabel6.Text = "Details of selected meal";
            // 
            // IngredientsListView
            // 
            IngredientsListView.AllowColumnReorder = true;
            IngredientsListView.AutoSizeTable = false;
            IngredientsListView.BackColor = Color.FromArgb(255, 255, 255);
            IngredientsListView.BorderStyle = BorderStyle.None;
            IngredientsListView.Columns.AddRange(new ColumnHeader[] { SkładnikiHeader });
            IngredientsListView.Depth = 0;
            IngredientsListView.Font = new Font("Microsoft Sans Serif", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            IngredientsListView.FullRowSelect = true;
            IngredientsListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            IngredientsListView.Location = new Point(620, 232);
            IngredientsListView.Margin = new Padding(4, 3, 4, 3);
            IngredientsListView.MinimumSize = new Size(250, 150);
            IngredientsListView.MouseLocation = new Point(-1, -1);
            IngredientsListView.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            IngredientsListView.MultiSelect = false;
            IngredientsListView.Name = "IngredientsListView";
            IngredientsListView.OwnerDraw = true;
            IngredientsListView.Size = new Size(456, 150);
            IngredientsListView.TabIndex = 41;
            IngredientsListView.UseCompatibleStateImageBehavior = false;
            IngredientsListView.View = View.Details;
            // 
            // SkładnikiHeader
            // 
            SkładnikiHeader.Text = "Ingredients";
            SkładnikiHeader.Width = 340;
            // 
            // AlergensListView
            // 
            AlergensListView.AllowColumnReorder = true;
            AlergensListView.AutoSizeTable = false;
            AlergensListView.BackColor = Color.FromArgb(255, 255, 255);
            AlergensListView.BorderStyle = BorderStyle.None;
            AlergensListView.Columns.AddRange(new ColumnHeader[] { AlergensHeader });
            AlergensListView.Depth = 0;
            AlergensListView.Font = new Font("Microsoft Sans Serif", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            AlergensListView.FullRowSelect = true;
            AlergensListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            AlergensListView.Location = new Point(620, 388);
            AlergensListView.Margin = new Padding(4, 3, 4, 3);
            AlergensListView.MinimumSize = new Size(250, 150);
            AlergensListView.MouseLocation = new Point(-1, -1);
            AlergensListView.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            AlergensListView.MultiSelect = false;
            AlergensListView.Name = "AlergensListView";
            AlergensListView.OwnerDraw = true;
            AlergensListView.Size = new Size(456, 150);
            AlergensListView.TabIndex = 43;
            AlergensListView.UseCompatibleStateImageBehavior = false;
            AlergensListView.View = View.Details;
            // 
            // AlergensHeader
            // 
            AlergensHeader.Text = "Allergens";
            AlergensHeader.Width = 340;
            // 
            // materialLabel3
            // 
            materialLabel3.AutoSize = true;
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.Location = new Point(249, 137);
            materialLabel3.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(124, 19);
            materialLabel3.TabIndex = 44;
            materialLabel3.Text = "Is the diet vegan?";
            // 
            // IsVeganLabel
            // 
            IsVeganLabel.AutoSize = true;
            IsVeganLabel.Depth = 0;
            IsVeganLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            IsVeganLabel.Location = new Point(434, 138);
            IsVeganLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            IsVeganLabel.Name = "IsVeganLabel";
            IsVeganLabel.Size = new Size(27, 19);
            IsVeganLabel.TabIndex = 45;
            IsVeganLabel.Text = "Yes";
            // 
            // DietDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 560);
            Controls.Add(IsVeganLabel);
            Controls.Add(materialLabel3);
            Controls.Add(AlergensListView);
            Controls.Add(IngredientsListView);
            Controls.Add(materialLabel6);
            Controls.Add(MealsListView);
            Controls.Add(materialLabel5);
            Controls.Add(DietPriceLabel);
            Controls.Add(DietKcalLabel);
            Controls.Add(materialLabel2);
            Controls.Add(materialLabel1);
            Controls.Add(DietNameLabel);
            Name = "DietDetailsForm";
            Text = "Diet details";
            TransparencyKey = Color.Fuchsia;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialLabel DietNameLabel;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel2;
        private ReaLTaiizor.Controls.MaterialLabel DietKcalLabel;
        private ReaLTaiizor.Controls.MaterialLabel DietPriceLabel;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel5;
        private ReaLTaiizor.Controls.MaterialListView MealsListView;
        private ColumnHeader MealNameHeader;
        private ColumnHeader MealCaloriesHeader;
        private ColumnHeader MealIDHeader;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel6;
        private ReaLTaiizor.Controls.MaterialListView IngredientsListView;
        private ColumnHeader SkładnikiHeader;
        private ReaLTaiizor.Controls.MaterialListView AlergensListView;
        private ColumnHeader AlergensHeader;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel3;
        private ReaLTaiizor.Controls.MaterialLabel IsVeganLabel;
    }
}