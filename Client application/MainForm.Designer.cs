using ReaLTaiizor.Controls;
using System.Windows.Forms;

namespace ReaLTaiizor.UI
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            materialTabControl1 = new MaterialTabControl();
            ShopPage = new System.Windows.Forms.TabPage();
            AddToCartButton = new MaterialButton();
            DietListView = new MaterialListView();
            NameHeader = new ColumnHeader();
            CaloriesHeader = new ColumnHeader();
            PriceHeader = new ColumnHeader();
            IsVeganHeader = new ColumnHeader();
            Id = new ColumnHeader();
            materialLabel24 = new MaterialLabel();
            materialLabel9 = new MaterialLabel();
            RefreshDietsButton = new MaterialButton();
            BasketPage = new System.Windows.Forms.TabPage();
            materialButton3 = new MaterialButton();
            PlaceOrderButton = new MaterialButton();
            TotalOrderCostLabel = new MaterialLabel();
            materialLabel12 = new MaterialLabel();
            DeliveryCommentTextBox = new MaterialRichTextBox();
            materialLabel11 = new MaterialLabel();
            materialLabel8 = new MaterialLabel();
            OrderToDate = new PoisonDateTime();
            materialLabel6 = new MaterialLabel();
            OrderFromDate = new PoisonDateTime();
            BasketListView = new MaterialListView();
            columnHeader5 = new ColumnHeader();
            columnHeader6 = new ColumnHeader();
            columnHeader7 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader9 = new ColumnHeader();
            materialLabel1 = new MaterialLabel();
            materialLabel3 = new MaterialLabel();
            OrderPage = new System.Windows.Forms.TabPage();
            ExportOrderToPDFButton = new MaterialButton();
            materialLabel14 = new MaterialLabel();
            OrderDetailCommentTextBox = new MaterialRichTextBox();
            materialLabel13 = new MaterialLabel();
            DietInOrderListView = new MaterialListView();
            DietNameHeader = new ColumnHeader();
            materialLabel10 = new MaterialLabel();
            OrderDetailPostalTextBox = new MaterialMaskedTextBox();
            OrderDetailCityTextBox = new MaterialTextBoxEdit();
            OderDetailStreetNoTextBox = new MaterialTextBoxEdit();
            OrderDetailStreetTextBox = new MaterialTextBoxEdit();
            OrderDetailTelephoneTextBox = new MaterialMaskedTextBox();
            RefreshOrdersButton = new MaterialButton();
            OrderListView = new MaterialListView();
            OrderIdHeader = new ColumnHeader();
            StartDateHeader = new ColumnHeader();
            EndDateHeader = new ColumnHeader();
            OrderPriceHeader = new ColumnHeader();
            materialLabel4 = new MaterialLabel();
            materialLabel5 = new MaterialLabel();
            BMIPage = new System.Windows.Forms.TabPage();
            materialLabel26 = new MaterialLabel();
            materialLabel30 = new MaterialLabel();
            materialLabel31 = new MaterialLabel();
            materialLabel32 = new MaterialLabel();
            materialLabel23 = new MaterialLabel();
            materialLabel25 = new MaterialLabel();
            materialLabel22 = new MaterialLabel();
            materialLabel21 = new MaterialLabel();
            materialLabel20 = new MaterialLabel();
            BMIResultLabel = new MaterialLabel();
            materialLabel19 = new MaterialLabel();
            CalculateBMIButton = new MaterialButton();
            BMIWeightTextBox = new MaterialTextBoxEdit();
            BMIHeightTextBox = new MaterialTextBoxEdit();
            materialLabel18 = new MaterialLabel();
            BMRResultLabel = new MaterialLabel();
            materialLabel17 = new MaterialLabel();
            CalculateBMRButton = new MaterialButton();
            FemaleRadioButton = new MaterialRadioButton();
            MaleRadioButton = new MaterialRadioButton();
            WeightTextBox = new MaterialTextBoxEdit();
            AgeTextBox = new MaterialTextBoxEdit();
            HeightTextBox = new MaterialTextBoxEdit();
            materialLabel16 = new MaterialLabel();
            materialLabel15 = new MaterialLabel();
            materialLabel7 = new MaterialLabel();
            DiagramPage = new System.Windows.Forms.TabPage();
            materialLabel33 = new MaterialLabel();
            WeightPlot = new ScottPlot.WinForms.FormsPlot();
            RemoveFromWeightDiagramButton = new MaterialButton();
            AddDiagramButton = new MaterialButton();
            AddDiagramWeigth = new MaterialTextBoxEdit();
            AddDiagramDate = new PoisonDateTime();
            DiagramItemsListView = new MaterialListView();
            DateHeader = new ColumnHeader();
            WeightHeader = new ColumnHeader();
            materialLabel29 = new MaterialLabel();
            ProfilePage = new System.Windows.Forms.TabPage();
            LogoutButton = new MaterialButton();
            PostalCodeTextBox = new MaterialMaskedTextBox();
            materialSwitch10 = new MaterialSwitch();
            NewPassAgainTextBox = new MaterialTextBoxEdit();
            NewPassTextBox = new MaterialTextBoxEdit();
            CurrentPassTextBox = new MaterialTextBoxEdit();
            CityTextBox = new MaterialTextBoxEdit();
            StreetNoTextBox = new MaterialTextBoxEdit();
            StreetTextBox = new MaterialTextBoxEdit();
            SaveChangesButton = new MaterialButton();
            ChangePassButton = new MaterialButton();
            SurnameTextBox = new MaterialTextBoxEdit();
            NameTextBox = new MaterialTextBoxEdit();
            PhoneTextBox = new MaterialMaskedTextBox();
            EmailTextBox = new MaterialTextBoxEdit();
            materialLabel27 = new MaterialLabel();
            materialLabel56 = new MaterialLabel();
            SettingsPage = new System.Windows.Forms.TabPage();
            colorSchemeListView = new MaterialListView();
            ColorSchemeName = new ColumnHeader();
            materialLabel2 = new MaterialLabel();
            ChangeColorSchemeButton = new MaterialButton();
            CertificatePinningCheckBox = new MaterialCheckBox();
            materialLabel28 = new MaterialLabel();
            menuIconList = new ImageList(components);
            materialContextMenuStrip1 = new MaterialContextMenuStrip();
            item1ToolStripMenuItem = new MaterialToolStripMenuItem();
            subItem1ToolStripMenuItem = new MaterialToolStripMenuItem();
            subItem2ToolStripMenuItem = new MaterialToolStripMenuItem();
            disabledItemToolStripMenuItem = new ToolStripMenuItem();
            item2ToolStripMenuItem = new MaterialToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            item3ToolStripMenuItem = new MaterialToolStripMenuItem();
            materialTabControl1.SuspendLayout();
            ShopPage.SuspendLayout();
            BasketPage.SuspendLayout();
            OrderPage.SuspendLayout();
            BMIPage.SuspendLayout();
            DiagramPage.SuspendLayout();
            ProfilePage.SuspendLayout();
            SettingsPage.SuspendLayout();
            materialContextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // materialTabControl1
            // 
            materialTabControl1.Controls.Add(ShopPage);
            materialTabControl1.Controls.Add(BasketPage);
            materialTabControl1.Controls.Add(OrderPage);
            materialTabControl1.Controls.Add(BMIPage);
            materialTabControl1.Controls.Add(DiagramPage);
            materialTabControl1.Controls.Add(ProfilePage);
            materialTabControl1.Controls.Add(SettingsPage);
            materialTabControl1.Depth = 0;
            materialTabControl1.Dock = DockStyle.Fill;
            materialTabControl1.ImageList = menuIconList;
            materialTabControl1.Location = new Point(4, 74);
            materialTabControl1.Margin = new Padding(4, 3, 4, 3);
            materialTabControl1.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialTabControl1.Multiline = true;
            materialTabControl1.Name = "materialTabControl1";
            materialTabControl1.SelectedIndex = 0;
            materialTabControl1.Size = new Size(1192, 683);
            materialTabControl1.TabIndex = 18;
            // 
            // ShopPage
            // 
            ShopPage.BackColor = Color.White;
            ShopPage.Controls.Add(AddToCartButton);
            ShopPage.Controls.Add(DietListView);
            ShopPage.Controls.Add(materialLabel24);
            ShopPage.Controls.Add(materialLabel9);
            ShopPage.Controls.Add(RefreshDietsButton);
            ShopPage.ImageKey = "shopping_bag_24dp_E8EAED_FILL0_wght300_GRAD0_opsz24.png";
            ShopPage.Location = new Point(4, 31);
            ShopPage.Margin = new Padding(4, 3, 4, 3);
            ShopPage.Name = "ShopPage";
            ShopPage.Size = new Size(1184, 648);
            ShopPage.TabIndex = 0;
            ShopPage.Text = "Shop";
            // 
            // AddToCartButton
            // 
            AddToCartButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddToCartButton.CharacterCasing = MaterialButton.CharacterCasingEnum.Normal;
            AddToCartButton.Density = MaterialButton.MaterialButtonDensity.Default;
            AddToCartButton.Depth = 0;
            AddToCartButton.HighEmphasis = true;
            AddToCartButton.Icon = null;
            AddToCartButton.IconType = MaterialButton.MaterialIconType.Rebase;
            AddToCartButton.Location = new Point(721, 167);
            AddToCartButton.Margin = new Padding(5, 7, 5, 7);
            AddToCartButton.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.NoAccentTextColor = Color.Empty;
            AddToCartButton.Size = new Size(131, 36);
            AddToCartButton.TabIndex = 34;
            AddToCartButton.Text = "Add to basket";
            AddToCartButton.Type = MaterialButton.MaterialButtonType.Contained;
            AddToCartButton.UseAccentColor = true;
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // DietListView
            // 
            DietListView.AllowColumnReorder = true;
            DietListView.AutoSizeTable = false;
            DietListView.BackColor = Color.FromArgb(255, 255, 255);
            DietListView.BorderStyle = BorderStyle.None;
            DietListView.Columns.AddRange(new ColumnHeader[] { NameHeader, CaloriesHeader, PriceHeader, IsVeganHeader, Id });
            DietListView.Depth = 0;
            DietListView.Font = new Font("Microsoft Sans Serif", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            DietListView.FullRowSelect = true;
            DietListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            DietListView.Location = new Point(22, 213);
            DietListView.Margin = new Padding(4, 3, 4, 3);
            DietListView.MinimumSize = new Size(250, 400);
            DietListView.MouseLocation = new Point(-1, -1);
            DietListView.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            DietListView.MultiSelect = false;
            DietListView.Name = "DietListView";
            DietListView.OwnerDraw = true;
            DietListView.Size = new Size(860, 400);
            DietListView.TabIndex = 33;
            DietListView.UseCompatibleStateImageBehavior = false;
            DietListView.View = View.Details;
            DietListView.ColumnWidthChanging += DietListView_ColumnWidthChanging;
            DietListView.DoubleClick += DietListView_DoubleClick;
            // 
            // NameHeader
            // 
            NameHeader.Text = "Name";
            NameHeader.Width = 340;
            // 
            // CaloriesHeader
            // 
            CaloriesHeader.Text = "Calories (kcal)";
            CaloriesHeader.Width = 150;
            // 
            // PriceHeader
            // 
            PriceHeader.Text = "Price per day (PLN)";
            PriceHeader.Width = 160;
            // 
            // IsVeganHeader
            // 
            IsVeganHeader.Text = "Is vegan?";
            IsVeganHeader.Width = 190;
            // 
            // Id
            // 
            Id.Width = 0;
            // 
            // materialLabel24
            // 
            materialLabel24.AutoSize = true;
            materialLabel24.Depth = 0;
            materialLabel24.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel24.FontType = Manager.MaterialSkinManager.FontType.H3;
            materialLabel24.Location = new Point(24, 20);
            materialLabel24.Margin = new Padding(4, 0, 4, 0);
            materialLabel24.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel24.Name = "materialLabel24";
            materialLabel24.Size = new Size(109, 58);
            materialLabel24.TabIndex = 32;
            materialLabel24.Text = "Shop";
            // 
            // materialLabel9
            // 
            materialLabel9.Depth = 0;
            materialLabel9.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel9.ForeColor = Color.FromArgb(180, 0, 0, 0);
            materialLabel9.Location = new Point(22, 91);
            materialLabel9.Margin = new Padding(4, 0, 4, 0);
            materialLabel9.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel9.Name = "materialLabel9";
            materialLabel9.Size = new Size(531, 69);
            materialLabel9.TabIndex = 0;
            materialLabel9.Text = "Below you will find the diets on offer. Double-click on the diet you are interested in to find out the composition of the meals, including their ingredients and allergens.";
            // 
            // RefreshDietsButton
            // 
            RefreshDietsButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RefreshDietsButton.CharacterCasing = MaterialButton.CharacterCasingEnum.Normal;
            RefreshDietsButton.Density = MaterialButton.MaterialButtonDensity.Default;
            RefreshDietsButton.Depth = 0;
            RefreshDietsButton.HighEmphasis = true;
            RefreshDietsButton.Icon = null;
            RefreshDietsButton.IconType = MaterialButton.MaterialIconType.Rebase;
            RefreshDietsButton.Location = new Point(24, 167);
            RefreshDietsButton.Margin = new Padding(5, 7, 5, 7);
            RefreshDietsButton.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            RefreshDietsButton.Name = "RefreshDietsButton";
            RefreshDietsButton.NoAccentTextColor = Color.Empty;
            RefreshDietsButton.Size = new Size(128, 36);
            RefreshDietsButton.TabIndex = 22;
            RefreshDietsButton.Text = "Refresh diets";
            RefreshDietsButton.Type = MaterialButton.MaterialButtonType.Contained;
            RefreshDietsButton.UseAccentColor = false;
            RefreshDietsButton.UseVisualStyleBackColor = true;
            RefreshDietsButton.Click += RefreshDietsButton_Click;
            // 
            // BasketPage
            // 
            BasketPage.Controls.Add(materialButton3);
            BasketPage.Controls.Add(PlaceOrderButton);
            BasketPage.Controls.Add(TotalOrderCostLabel);
            BasketPage.Controls.Add(materialLabel12);
            BasketPage.Controls.Add(DeliveryCommentTextBox);
            BasketPage.Controls.Add(materialLabel11);
            BasketPage.Controls.Add(materialLabel8);
            BasketPage.Controls.Add(OrderToDate);
            BasketPage.Controls.Add(materialLabel6);
            BasketPage.Controls.Add(OrderFromDate);
            BasketPage.Controls.Add(BasketListView);
            BasketPage.Controls.Add(materialLabel1);
            BasketPage.Controls.Add(materialLabel3);
            BasketPage.ImageKey = "shopping_cart_24dp_E8EAED_FILL0_wght300_GRAD0_opsz24.png";
            BasketPage.Location = new Point(4, 31);
            BasketPage.Name = "BasketPage";
            BasketPage.Size = new Size(1184, 648);
            BasketPage.TabIndex = 6;
            BasketPage.Text = "Basket";
            BasketPage.UseVisualStyleBackColor = true;
            // 
            // materialButton3
            // 
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.CharacterCasing = MaterialButton.CharacterCasingEnum.Normal;
            materialButton3.Density = MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.IconType = MaterialButton.MaterialIconType.Rebase;
            materialButton3.Location = new Point(891, 340);
            materialButton3.Margin = new Padding(5, 7, 5, 7);
            materialButton3.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(175, 36);
            materialButton3.TabIndex = 47;
            materialButton3.Text = "Delete from basket";
            materialButton3.Type = MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            materialButton3.Click += materialButton3_Click_1;
            // 
            // PlaceOrderButton
            // 
            PlaceOrderButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            PlaceOrderButton.CharacterCasing = MaterialButton.CharacterCasingEnum.Normal;
            PlaceOrderButton.Density = MaterialButton.MaterialButtonDensity.Default;
            PlaceOrderButton.Depth = 0;
            PlaceOrderButton.HighEmphasis = true;
            PlaceOrderButton.Icon = null;
            PlaceOrderButton.IconType = MaterialButton.MaterialIconType.Rebase;
            PlaceOrderButton.Location = new Point(741, 571);
            PlaceOrderButton.Margin = new Padding(5, 7, 5, 7);
            PlaceOrderButton.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            PlaceOrderButton.Name = "PlaceOrderButton";
            PlaceOrderButton.NoAccentTextColor = Color.Empty;
            PlaceOrderButton.Size = new Size(141, 36);
            PlaceOrderButton.TabIndex = 46;
            PlaceOrderButton.Text = "Place an order";
            PlaceOrderButton.Type = MaterialButton.MaterialButtonType.Contained;
            PlaceOrderButton.UseAccentColor = true;
            PlaceOrderButton.UseVisualStyleBackColor = true;
            PlaceOrderButton.Click += PlaceOrderButton_Click;
            // 
            // TotalOrderCostLabel
            // 
            TotalOrderCostLabel.Depth = 0;
            TotalOrderCostLabel.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            TotalOrderCostLabel.Location = new Point(762, 512);
            TotalOrderCostLabel.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            TotalOrderCostLabel.Name = "TotalOrderCostLabel";
            TotalOrderCostLabel.Size = new Size(120, 19);
            TotalOrderCostLabel.TabIndex = 45;
            TotalOrderCostLabel.Text = "0 PLN";
            TotalOrderCostLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // materialLabel12
            // 
            materialLabel12.AutoSize = true;
            materialLabel12.Depth = 0;
            materialLabel12.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel12.Location = new Point(550, 512);
            materialLabel12.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel12.Name = "materialLabel12";
            materialLabel12.Size = new Size(135, 19);
            materialLabel12.TabIndex = 44;
            materialLabel12.Text = "Total cost of order:";
            // 
            // DeliveryCommentTextBox
            // 
            DeliveryCommentTextBox.BackColor = Color.FromArgb(255, 255, 255);
            DeliveryCommentTextBox.BorderStyle = BorderStyle.None;
            DeliveryCommentTextBox.Depth = 0;
            DeliveryCommentTextBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            DeliveryCommentTextBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            DeliveryCommentTextBox.Hint = "";
            DeliveryCommentTextBox.Location = new Point(22, 511);
            DeliveryCommentTextBox.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            DeliveryCommentTextBox.Name = "DeliveryCommentTextBox";
            DeliveryCommentTextBox.Size = new Size(471, 96);
            DeliveryCommentTextBox.TabIndex = 43;
            DeliveryCommentTextBox.Text = "";
            // 
            // materialLabel11
            // 
            materialLabel11.AutoSize = true;
            materialLabel11.Depth = 0;
            materialLabel11.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel11.Location = new Point(22, 475);
            materialLabel11.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel11.Name = "materialLabel11";
            materialLabel11.Size = new Size(138, 19);
            materialLabel11.TabIndex = 42;
            materialLabel11.Text = "Comment for order:";
            // 
            // materialLabel8
            // 
            materialLabel8.AutoSize = true;
            materialLabel8.Depth = 0;
            materialLabel8.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel8.Location = new Point(22, 437);
            materialLabel8.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel8.Name = "materialLabel8";
            materialLabel8.Size = new Size(185, 19);
            materialLabel8.TabIndex = 41;
            materialLabel8.Text = "Last day for ordered diets:";
            // 
            // OrderToDate
            // 
            OrderToDate.Location = new Point(293, 429);
            OrderToDate.MinimumSize = new Size(0, 29);
            OrderToDate.Name = "OrderToDate";
            OrderToDate.Size = new Size(200, 29);
            OrderToDate.TabIndex = 40;
            OrderToDate.ValueChanged += OrderToDate_ValueChanged;
            // 
            // materialLabel6
            // 
            materialLabel6.AutoSize = true;
            materialLabel6.Depth = 0;
            materialLabel6.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel6.Location = new Point(22, 396);
            materialLabel6.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel6.Name = "materialLabel6";
            materialLabel6.Size = new Size(185, 19);
            materialLabel6.TabIndex = 39;
            materialLabel6.Text = "First day for ordered diets:";
            // 
            // OrderFromDate
            // 
            OrderFromDate.Location = new Point(293, 388);
            OrderFromDate.MinimumSize = new Size(0, 29);
            OrderFromDate.Name = "OrderFromDate";
            OrderFromDate.Size = new Size(200, 29);
            OrderFromDate.TabIndex = 38;
            OrderFromDate.ValueChanged += OrderFromDate_ValueChanged;
            // 
            // BasketListView
            // 
            BasketListView.AllowColumnReorder = true;
            BasketListView.AutoSizeTable = false;
            BasketListView.BackColor = Color.FromArgb(255, 255, 255);
            BasketListView.BorderStyle = BorderStyle.None;
            BasketListView.Columns.AddRange(new ColumnHeader[] { columnHeader5, columnHeader6, columnHeader7, columnHeader8, columnHeader9 });
            BasketListView.Depth = 0;
            BasketListView.Font = new Font("Microsoft Sans Serif", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            BasketListView.FullRowSelect = true;
            BasketListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            BasketListView.Location = new Point(22, 176);
            BasketListView.Margin = new Padding(4, 3, 4, 3);
            BasketListView.MinimumSize = new Size(250, 200);
            BasketListView.MouseLocation = new Point(-1, -1);
            BasketListView.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            BasketListView.MultiSelect = false;
            BasketListView.Name = "BasketListView";
            BasketListView.OwnerDraw = true;
            BasketListView.Size = new Size(860, 200);
            BasketListView.TabIndex = 35;
            BasketListView.UseCompatibleStateImageBehavior = false;
            BasketListView.View = View.Details;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Name";
            columnHeader5.Width = 340;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Calories (kcal)";
            columnHeader6.Width = 150;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Price per day (PLN)";
            columnHeader7.Width = 160;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Is vegan?";
            columnHeader8.Width = 190;
            // 
            // columnHeader9
            // 
            columnHeader9.Width = 0;
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.BackColor = Color.Violet;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = Manager.MaterialSkinManager.FontType.H3;
            materialLabel1.Location = new Point(24, 20);
            materialLabel1.Margin = new Padding(4, 0, 4, 0);
            materialLabel1.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(147, 58);
            materialLabel1.TabIndex = 34;
            materialLabel1.Text = "Basket";
            // 
            // materialLabel3
            // 
            materialLabel3.Depth = 0;
            materialLabel3.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel3.ForeColor = Color.FromArgb(180, 0, 0, 0);
            materialLabel3.Location = new Point(22, 91);
            materialLabel3.Margin = new Padding(4, 0, 4, 0);
            materialLabel3.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel3.Name = "materialLabel3";
            materialLabel3.Size = new Size(531, 69);
            materialLabel3.TabIndex = 33;
            materialLabel3.Text = "Below is a list of the diets currently in your shopping basket. To order, select the period for which you would like to order.";
            // 
            // OrderPage
            // 
            OrderPage.BackColor = Color.White;
            OrderPage.Controls.Add(ExportOrderToPDFButton);
            OrderPage.Controls.Add(materialLabel14);
            OrderPage.Controls.Add(OrderDetailCommentTextBox);
            OrderPage.Controls.Add(materialLabel13);
            OrderPage.Controls.Add(DietInOrderListView);
            OrderPage.Controls.Add(materialLabel10);
            OrderPage.Controls.Add(OrderDetailPostalTextBox);
            OrderPage.Controls.Add(OrderDetailCityTextBox);
            OrderPage.Controls.Add(OderDetailStreetNoTextBox);
            OrderPage.Controls.Add(OrderDetailStreetTextBox);
            OrderPage.Controls.Add(OrderDetailTelephoneTextBox);
            OrderPage.Controls.Add(RefreshOrdersButton);
            OrderPage.Controls.Add(OrderListView);
            OrderPage.Controls.Add(materialLabel4);
            OrderPage.Controls.Add(materialLabel5);
            OrderPage.ImageKey = "local_shipping_24dp_E8EAED_FILL0_wght300_GRAD0_opsz24.png";
            OrderPage.Location = new Point(4, 31);
            OrderPage.Margin = new Padding(4, 3, 4, 3);
            OrderPage.Name = "OrderPage";
            OrderPage.Padding = new Padding(4, 3, 4, 3);
            OrderPage.Size = new Size(1184, 648);
            OrderPage.TabIndex = 1;
            OrderPage.Text = "Order history";
            // 
            // ExportOrderToPDFButton
            // 
            ExportOrderToPDFButton.AutoSize = false;
            ExportOrderToPDFButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ExportOrderToPDFButton.CharacterCasing = MaterialButton.CharacterCasingEnum.Normal;
            ExportOrderToPDFButton.Density = MaterialButton.MaterialButtonDensity.Default;
            ExportOrderToPDFButton.Depth = 0;
            ExportOrderToPDFButton.HighEmphasis = true;
            ExportOrderToPDFButton.Icon = null;
            ExportOrderToPDFButton.IconType = MaterialButton.MaterialIconType.Rebase;
            ExportOrderToPDFButton.Location = new Point(691, 224);
            ExportOrderToPDFButton.Margin = new Padding(5, 7, 5, 7);
            ExportOrderToPDFButton.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ExportOrderToPDFButton.Name = "ExportOrderToPDFButton";
            ExportOrderToPDFButton.NoAccentTextColor = Color.Empty;
            ExportOrderToPDFButton.Size = new Size(129, 54);
            ExportOrderToPDFButton.TabIndex = 105;
            ExportOrderToPDFButton.Text = "Export order to PDF";
            ExportOrderToPDFButton.Type = MaterialButton.MaterialButtonType.Contained;
            ExportOrderToPDFButton.UseAccentColor = true;
            ExportOrderToPDFButton.UseVisualStyleBackColor = true;
            ExportOrderToPDFButton.Click += ExportOrderToPDFButton_Click;
            // 
            // materialLabel14
            // 
            materialLabel14.AutoSize = true;
            materialLabel14.Depth = 0;
            materialLabel14.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel14.Location = new Point(24, 534);
            materialLabel14.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel14.Name = "materialLabel14";
            materialLabel14.Size = new Size(134, 19);
            materialLabel14.TabIndex = 104;
            materialLabel14.Text = "Comment for order";
            // 
            // OrderDetailCommentTextBox
            // 
            OrderDetailCommentTextBox.BackColor = Color.FromArgb(255, 255, 255);
            OrderDetailCommentTextBox.BorderStyle = BorderStyle.None;
            OrderDetailCommentTextBox.Depth = 0;
            OrderDetailCommentTextBox.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            OrderDetailCommentTextBox.ForeColor = Color.FromArgb(222, 0, 0, 0);
            OrderDetailCommentTextBox.Hint = "";
            OrderDetailCommentTextBox.Location = new Point(24, 556);
            OrderDetailCommentTextBox.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            OrderDetailCommentTextBox.Name = "OrderDetailCommentTextBox";
            OrderDetailCommentTextBox.ReadOnly = true;
            OrderDetailCommentTextBox.Size = new Size(498, 38);
            OrderDetailCommentTextBox.TabIndex = 103;
            OrderDetailCommentTextBox.Text = "";
            // 
            // materialLabel13
            // 
            materialLabel13.Depth = 0;
            materialLabel13.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel13.ForeColor = Color.FromArgb(180, 0, 0, 0);
            materialLabel13.Location = new Point(22, 330);
            materialLabel13.Margin = new Padding(4, 0, 4, 0);
            materialLabel13.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel13.Name = "materialLabel13";
            materialLabel13.Size = new Size(531, 48);
            materialLabel13.TabIndex = 102;
            materialLabel13.Text = "Below you will find details of the order you have selected, such as delivery address details and the diets included in the order";
            // 
            // DietInOrderListView
            // 
            DietInOrderListView.AllowColumnReorder = true;
            DietInOrderListView.AutoSizeTable = false;
            DietInOrderListView.BackColor = Color.FromArgb(255, 255, 255);
            DietInOrderListView.BorderStyle = BorderStyle.None;
            DietInOrderListView.Columns.AddRange(new ColumnHeader[] { DietNameHeader });
            DietInOrderListView.Depth = 0;
            DietInOrderListView.Font = new Font("Microsoft Sans Serif", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            DietInOrderListView.FullRowSelect = true;
            DietInOrderListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            DietInOrderListView.Location = new Point(22, 381);
            DietInOrderListView.Margin = new Padding(4, 3, 4, 3);
            DietInOrderListView.MinimumSize = new Size(340, 150);
            DietInOrderListView.MouseLocation = new Point(-1, -1);
            DietInOrderListView.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            DietInOrderListView.MultiSelect = false;
            DietInOrderListView.Name = "DietInOrderListView";
            DietInOrderListView.OwnerDraw = true;
            DietInOrderListView.Size = new Size(500, 150);
            DietInOrderListView.TabIndex = 101;
            DietInOrderListView.UseCompatibleStateImageBehavior = false;
            DietInOrderListView.View = View.Details;
            // 
            // DietNameHeader
            // 
            DietNameHeader.Text = "Diet name";
            DietNameHeader.Width = 500;
            // 
            // materialLabel10
            // 
            materialLabel10.AutoSize = true;
            materialLabel10.BackColor = Color.Violet;
            materialLabel10.Depth = 0;
            materialLabel10.Font = new Font("Roboto", 24F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel10.FontType = Manager.MaterialSkinManager.FontType.H5;
            materialLabel10.Location = new Point(22, 291);
            materialLabel10.Margin = new Padding(4, 0, 4, 0);
            materialLabel10.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel10.Name = "materialLabel10";
            materialLabel10.Size = new Size(139, 29);
            materialLabel10.TabIndex = 100;
            materialLabel10.Text = "Order details";
            // 
            // OrderDetailPostalTextBox
            // 
            OrderDetailPostalTextBox.AllowPromptAsInput = true;
            OrderDetailPostalTextBox.AnimateReadOnly = false;
            OrderDetailPostalTextBox.AsciiOnly = false;
            OrderDetailPostalTextBox.BackgroundImageLayout = ImageLayout.None;
            OrderDetailPostalTextBox.BeepOnError = false;
            OrderDetailPostalTextBox.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            OrderDetailPostalTextBox.Depth = 0;
            OrderDetailPostalTextBox.Enabled = false;
            OrderDetailPostalTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            OrderDetailPostalTextBox.HidePromptOnLeave = true;
            OrderDetailPostalTextBox.HideSelection = false;
            OrderDetailPostalTextBox.Hint = "Postal code";
            OrderDetailPostalTextBox.InsertKeyMode = InsertKeyMode.Default;
            OrderDetailPostalTextBox.LeadingIcon = null;
            OrderDetailPostalTextBox.Location = new Point(821, 435);
            OrderDetailPostalTextBox.Margin = new Padding(4, 3, 4, 3);
            OrderDetailPostalTextBox.Mask = "00-000";
            OrderDetailPostalTextBox.MaxLength = 32767;
            OrderDetailPostalTextBox.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            OrderDetailPostalTextBox.Name = "OrderDetailPostalTextBox";
            OrderDetailPostalTextBox.PasswordChar = '\0';
            OrderDetailPostalTextBox.PrefixSuffixText = null;
            OrderDetailPostalTextBox.PromptChar = '_';
            OrderDetailPostalTextBox.ReadOnly = true;
            OrderDetailPostalTextBox.RejectInputOnFirstFailure = true;
            OrderDetailPostalTextBox.ResetOnPrompt = true;
            OrderDetailPostalTextBox.ResetOnSpace = true;
            OrderDetailPostalTextBox.RightToLeft = RightToLeft.No;
            OrderDetailPostalTextBox.SelectedText = "";
            OrderDetailPostalTextBox.SelectionLength = 0;
            OrderDetailPostalTextBox.SelectionStart = 3;
            OrderDetailPostalTextBox.ShortcutsEnabled = true;
            OrderDetailPostalTextBox.Size = new Size(130, 48);
            OrderDetailPostalTextBox.SkipLiterals = true;
            OrderDetailPostalTextBox.TabIndex = 99;
            OrderDetailPostalTextBox.TabStop = false;
            OrderDetailPostalTextBox.Text = "  -";
            OrderDetailPostalTextBox.TextAlign = HorizontalAlignment.Left;
            OrderDetailPostalTextBox.TextMaskFormat = MaskFormat.IncludeLiterals;
            OrderDetailPostalTextBox.TrailingIcon = null;
            OrderDetailPostalTextBox.UseSystemPasswordChar = false;
            OrderDetailPostalTextBox.ValidatingType = null;
            // 
            // OrderDetailCityTextBox
            // 
            OrderDetailCityTextBox.AnimateReadOnly = false;
            OrderDetailCityTextBox.AutoCompleteMode = AutoCompleteMode.None;
            OrderDetailCityTextBox.AutoCompleteSource = AutoCompleteSource.None;
            OrderDetailCityTextBox.BackgroundImageLayout = ImageLayout.None;
            OrderDetailCityTextBox.CharacterCasing = CharacterCasing.Normal;
            OrderDetailCityTextBox.Cursor = Cursors.IBeam;
            OrderDetailCityTextBox.Depth = 0;
            OrderDetailCityTextBox.Enabled = false;
            OrderDetailCityTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            OrderDetailCityTextBox.HideSelection = true;
            OrderDetailCityTextBox.Hint = "City";
            OrderDetailCityTextBox.LeadingIcon = null;
            OrderDetailCityTextBox.Location = new Point(529, 435);
            OrderDetailCityTextBox.Margin = new Padding(4, 3, 4, 3);
            OrderDetailCityTextBox.MaxLength = 50;
            OrderDetailCityTextBox.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            OrderDetailCityTextBox.Name = "OrderDetailCityTextBox";
            OrderDetailCityTextBox.PasswordChar = '\0';
            OrderDetailCityTextBox.PrefixSuffixText = null;
            OrderDetailCityTextBox.ReadOnly = true;
            OrderDetailCityTextBox.RightToLeft = RightToLeft.No;
            OrderDetailCityTextBox.SelectedText = "";
            OrderDetailCityTextBox.SelectionLength = 0;
            OrderDetailCityTextBox.SelectionStart = 0;
            OrderDetailCityTextBox.ShortcutsEnabled = true;
            OrderDetailCityTextBox.Size = new Size(284, 48);
            OrderDetailCityTextBox.TabIndex = 98;
            OrderDetailCityTextBox.TabStop = false;
            OrderDetailCityTextBox.TextAlign = HorizontalAlignment.Left;
            OrderDetailCityTextBox.TrailingIcon = null;
            OrderDetailCityTextBox.UseSystemPasswordChar = false;
            // 
            // OderDetailStreetNoTextBox
            // 
            OderDetailStreetNoTextBox.AnimateReadOnly = false;
            OderDetailStreetNoTextBox.AutoCompleteMode = AutoCompleteMode.None;
            OderDetailStreetNoTextBox.AutoCompleteSource = AutoCompleteSource.None;
            OderDetailStreetNoTextBox.BackgroundImageLayout = ImageLayout.None;
            OderDetailStreetNoTextBox.CharacterCasing = CharacterCasing.Normal;
            OderDetailStreetNoTextBox.Cursor = Cursors.IBeam;
            OderDetailStreetNoTextBox.Depth = 0;
            OderDetailStreetNoTextBox.Enabled = false;
            OderDetailStreetNoTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            OderDetailStreetNoTextBox.HideSelection = true;
            OderDetailStreetNoTextBox.Hint = "Street No.";
            OderDetailStreetNoTextBox.LeadingIcon = null;
            OderDetailStreetNoTextBox.Location = new Point(529, 546);
            OderDetailStreetNoTextBox.Margin = new Padding(4, 3, 4, 3);
            OderDetailStreetNoTextBox.MaxLength = 50;
            OderDetailStreetNoTextBox.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            OderDetailStreetNoTextBox.Name = "OderDetailStreetNoTextBox";
            OderDetailStreetNoTextBox.PasswordChar = '\0';
            OderDetailStreetNoTextBox.PrefixSuffixText = null;
            OderDetailStreetNoTextBox.ReadOnly = true;
            OderDetailStreetNoTextBox.RightToLeft = RightToLeft.No;
            OderDetailStreetNoTextBox.SelectedText = "";
            OderDetailStreetNoTextBox.SelectionLength = 0;
            OderDetailStreetNoTextBox.SelectionStart = 0;
            OderDetailStreetNoTextBox.ShortcutsEnabled = true;
            OderDetailStreetNoTextBox.Size = new Size(423, 48);
            OderDetailStreetNoTextBox.TabIndex = 97;
            OderDetailStreetNoTextBox.TabStop = false;
            OderDetailStreetNoTextBox.TextAlign = HorizontalAlignment.Left;
            OderDetailStreetNoTextBox.TrailingIcon = null;
            OderDetailStreetNoTextBox.UseSystemPasswordChar = false;
            // 
            // OrderDetailStreetTextBox
            // 
            OrderDetailStreetTextBox.AnimateReadOnly = false;
            OrderDetailStreetTextBox.AutoCompleteMode = AutoCompleteMode.None;
            OrderDetailStreetTextBox.AutoCompleteSource = AutoCompleteSource.None;
            OrderDetailStreetTextBox.BackgroundImageLayout = ImageLayout.None;
            OrderDetailStreetTextBox.CharacterCasing = CharacterCasing.Normal;
            OrderDetailStreetTextBox.Cursor = Cursors.IBeam;
            OrderDetailStreetTextBox.Depth = 0;
            OrderDetailStreetTextBox.Enabled = false;
            OrderDetailStreetTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            OrderDetailStreetTextBox.HideSelection = true;
            OrderDetailStreetTextBox.Hint = "Street";
            OrderDetailStreetTextBox.LeadingIcon = null;
            OrderDetailStreetTextBox.Location = new Point(529, 492);
            OrderDetailStreetTextBox.Margin = new Padding(4, 3, 4, 3);
            OrderDetailStreetTextBox.MaxLength = 50;
            OrderDetailStreetTextBox.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            OrderDetailStreetTextBox.Name = "OrderDetailStreetTextBox";
            OrderDetailStreetTextBox.PasswordChar = '\0';
            OrderDetailStreetTextBox.PrefixSuffixText = null;
            OrderDetailStreetTextBox.ReadOnly = true;
            OrderDetailStreetTextBox.RightToLeft = RightToLeft.No;
            OrderDetailStreetTextBox.SelectedText = "";
            OrderDetailStreetTextBox.SelectionLength = 0;
            OrderDetailStreetTextBox.SelectionStart = 0;
            OrderDetailStreetTextBox.ShortcutsEnabled = true;
            OrderDetailStreetTextBox.Size = new Size(422, 48);
            OrderDetailStreetTextBox.TabIndex = 96;
            OrderDetailStreetTextBox.TabStop = false;
            OrderDetailStreetTextBox.TextAlign = HorizontalAlignment.Left;
            OrderDetailStreetTextBox.TrailingIcon = null;
            OrderDetailStreetTextBox.UseSystemPasswordChar = false;
            // 
            // OrderDetailTelephoneTextBox
            // 
            OrderDetailTelephoneTextBox.AllowPromptAsInput = true;
            OrderDetailTelephoneTextBox.AnimateReadOnly = false;
            OrderDetailTelephoneTextBox.AsciiOnly = false;
            OrderDetailTelephoneTextBox.BackgroundImageLayout = ImageLayout.None;
            OrderDetailTelephoneTextBox.BeepOnError = false;
            OrderDetailTelephoneTextBox.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            OrderDetailTelephoneTextBox.Depth = 0;
            OrderDetailTelephoneTextBox.Enabled = false;
            OrderDetailTelephoneTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            OrderDetailTelephoneTextBox.HidePromptOnLeave = true;
            OrderDetailTelephoneTextBox.HideSelection = false;
            OrderDetailTelephoneTextBox.Hint = "Phone number";
            OrderDetailTelephoneTextBox.InsertKeyMode = InsertKeyMode.Default;
            OrderDetailTelephoneTextBox.LeadingIcon = null;
            OrderDetailTelephoneTextBox.Location = new Point(530, 381);
            OrderDetailTelephoneTextBox.Margin = new Padding(4, 3, 4, 3);
            OrderDetailTelephoneTextBox.Mask = "000-000-000";
            OrderDetailTelephoneTextBox.MaxLength = 32767;
            OrderDetailTelephoneTextBox.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            OrderDetailTelephoneTextBox.Name = "OrderDetailTelephoneTextBox";
            OrderDetailTelephoneTextBox.PasswordChar = '\0';
            OrderDetailTelephoneTextBox.PrefixSuffixText = null;
            OrderDetailTelephoneTextBox.PromptChar = '_';
            OrderDetailTelephoneTextBox.ReadOnly = true;
            OrderDetailTelephoneTextBox.RejectInputOnFirstFailure = true;
            OrderDetailTelephoneTextBox.ResetOnPrompt = true;
            OrderDetailTelephoneTextBox.ResetOnSpace = true;
            OrderDetailTelephoneTextBox.RightToLeft = RightToLeft.No;
            OrderDetailTelephoneTextBox.SelectedText = "";
            OrderDetailTelephoneTextBox.SelectionLength = 0;
            OrderDetailTelephoneTextBox.SelectionStart = 8;
            OrderDetailTelephoneTextBox.ShortcutsEnabled = true;
            OrderDetailTelephoneTextBox.Size = new Size(284, 48);
            OrderDetailTelephoneTextBox.SkipLiterals = true;
            OrderDetailTelephoneTextBox.TabIndex = 95;
            OrderDetailTelephoneTextBox.TabStop = false;
            OrderDetailTelephoneTextBox.Text = "   -   -";
            OrderDetailTelephoneTextBox.TextAlign = HorizontalAlignment.Left;
            OrderDetailTelephoneTextBox.TextMaskFormat = MaskFormat.IncludeLiterals;
            OrderDetailTelephoneTextBox.TrailingIcon = null;
            OrderDetailTelephoneTextBox.UseSystemPasswordChar = false;
            OrderDetailTelephoneTextBox.ValidatingType = null;
            // 
            // RefreshOrdersButton
            // 
            RefreshOrdersButton.AutoSize = false;
            RefreshOrdersButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RefreshOrdersButton.CharacterCasing = MaterialButton.CharacterCasingEnum.Normal;
            RefreshOrdersButton.Density = MaterialButton.MaterialButtonDensity.Default;
            RefreshOrdersButton.Depth = 0;
            RefreshOrdersButton.HighEmphasis = true;
            RefreshOrdersButton.Icon = null;
            RefreshOrdersButton.IconType = MaterialButton.MaterialIconType.Rebase;
            RefreshOrdersButton.Location = new Point(691, 128);
            RefreshOrdersButton.Margin = new Padding(5, 7, 5, 7);
            RefreshOrdersButton.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            RefreshOrdersButton.Name = "RefreshOrdersButton";
            RefreshOrdersButton.NoAccentTextColor = Color.Empty;
            RefreshOrdersButton.Size = new Size(129, 36);
            RefreshOrdersButton.TabIndex = 38;
            RefreshOrdersButton.Text = "Refresh order history";
            RefreshOrdersButton.Type = MaterialButton.MaterialButtonType.Contained;
            RefreshOrdersButton.UseAccentColor = false;
            RefreshOrdersButton.UseVisualStyleBackColor = true;
            RefreshOrdersButton.Click += RefreshOrdersButton_Click;
            // 
            // OrderListView
            // 
            OrderListView.AllowColumnReorder = true;
            OrderListView.AutoSizeTable = false;
            OrderListView.BackColor = Color.FromArgb(255, 255, 255);
            OrderListView.BorderStyle = BorderStyle.None;
            OrderListView.Columns.AddRange(new ColumnHeader[] { OrderIdHeader, StartDateHeader, EndDateHeader, OrderPriceHeader });
            OrderListView.Depth = 0;
            OrderListView.Font = new Font("Microsoft Sans Serif", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            OrderListView.FullRowSelect = true;
            OrderListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            OrderListView.Location = new Point(22, 128);
            OrderListView.Margin = new Padding(4, 3, 4, 3);
            OrderListView.MinimumSize = new Size(250, 150);
            OrderListView.MouseLocation = new Point(-1, -1);
            OrderListView.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            OrderListView.MultiSelect = false;
            OrderListView.Name = "OrderListView";
            OrderListView.OwnerDraw = true;
            OrderListView.Size = new Size(660, 150);
            OrderListView.TabIndex = 37;
            OrderListView.UseCompatibleStateImageBehavior = false;
            OrderListView.View = View.Details;
            OrderListView.SelectedIndexChanged += OrderListView_SelectedIndexChanged;
            // 
            // OrderIdHeader
            // 
            OrderIdHeader.Text = "Order id";
            OrderIdHeader.Width = 300;
            // 
            // StartDateHeader
            // 
            StartDateHeader.Text = "First day";
            StartDateHeader.Width = 130;
            // 
            // EndDateHeader
            // 
            EndDateHeader.Text = "Last day";
            EndDateHeader.Width = 130;
            // 
            // OrderPriceHeader
            // 
            OrderPriceHeader.Text = "Price";
            OrderPriceHeader.Width = 100;
            // 
            // materialLabel4
            // 
            materialLabel4.AutoSize = true;
            materialLabel4.BackColor = Color.Violet;
            materialLabel4.Depth = 0;
            materialLabel4.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel4.FontType = Manager.MaterialSkinManager.FontType.H3;
            materialLabel4.Location = new Point(24, 20);
            materialLabel4.Margin = new Padding(4, 0, 4, 0);
            materialLabel4.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel4.Name = "materialLabel4";
            materialLabel4.Size = new Size(275, 58);
            materialLabel4.TabIndex = 36;
            materialLabel4.Text = "Order history";
            // 
            // materialLabel5
            // 
            materialLabel5.Depth = 0;
            materialLabel5.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel5.ForeColor = Color.FromArgb(180, 0, 0, 0);
            materialLabel5.Location = new Point(22, 91);
            materialLabel5.Margin = new Padding(4, 0, 4, 0);
            materialLabel5.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel5.Name = "materialLabel5";
            materialLabel5.Size = new Size(531, 34);
            materialLabel5.TabIndex = 35;
            materialLabel5.Text = "Below is a list of all user orders";
            // 
            // BMIPage
            // 
            BMIPage.BackColor = Color.White;
            BMIPage.Controls.Add(materialLabel26);
            BMIPage.Controls.Add(materialLabel30);
            BMIPage.Controls.Add(materialLabel31);
            BMIPage.Controls.Add(materialLabel32);
            BMIPage.Controls.Add(materialLabel23);
            BMIPage.Controls.Add(materialLabel25);
            BMIPage.Controls.Add(materialLabel22);
            BMIPage.Controls.Add(materialLabel21);
            BMIPage.Controls.Add(materialLabel20);
            BMIPage.Controls.Add(BMIResultLabel);
            BMIPage.Controls.Add(materialLabel19);
            BMIPage.Controls.Add(CalculateBMIButton);
            BMIPage.Controls.Add(BMIWeightTextBox);
            BMIPage.Controls.Add(BMIHeightTextBox);
            BMIPage.Controls.Add(materialLabel18);
            BMIPage.Controls.Add(BMRResultLabel);
            BMIPage.Controls.Add(materialLabel17);
            BMIPage.Controls.Add(CalculateBMRButton);
            BMIPage.Controls.Add(FemaleRadioButton);
            BMIPage.Controls.Add(MaleRadioButton);
            BMIPage.Controls.Add(WeightTextBox);
            BMIPage.Controls.Add(AgeTextBox);
            BMIPage.Controls.Add(HeightTextBox);
            BMIPage.Controls.Add(materialLabel16);
            BMIPage.Controls.Add(materialLabel15);
            BMIPage.Controls.Add(materialLabel7);
            BMIPage.ImageKey = "calculate_24dp_E8EAED_FILL0_wght300_GRAD0_opsz24.png";
            BMIPage.Location = new Point(4, 31);
            BMIPage.Margin = new Padding(0);
            BMIPage.Name = "BMIPage";
            BMIPage.Size = new Size(1184, 648);
            BMIPage.TabIndex = 5;
            BMIPage.Text = "Calculators";
            // 
            // materialLabel26
            // 
            materialLabel26.AutoSize = true;
            materialLabel26.Depth = 0;
            materialLabel26.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel26.Location = new Point(678, 536);
            materialLabel26.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel26.Name = "materialLabel26";
            materialLabel26.Size = new Size(189, 19);
            materialLabel26.TabIndex = 106;
            materialLabel26.Text = "over 40.0 - extreme obesity";
            // 
            // materialLabel30
            // 
            materialLabel30.AutoSize = true;
            materialLabel30.Depth = 0;
            materialLabel30.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel30.Location = new Point(678, 517);
            materialLabel30.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel30.Name = "materialLabel30";
            materialLabel30.Size = new Size(205, 19);
            materialLabel30.TabIndex = 105;
            materialLabel30.Text = "35.0 to 39.00 - level II obesity";
            // 
            // materialLabel31
            // 
            materialLabel31.AutoSize = true;
            materialLabel31.Depth = 0;
            materialLabel31.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel31.Location = new Point(678, 498);
            materialLabel31.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel31.Name = "materialLabel31";
            materialLabel31.Size = new Size(208, 19);
            materialLabel31.TabIndex = 104;
            materialLabel31.Text = "30.0 to 34.99 - stage I obesity";
            // 
            // materialLabel32
            // 
            materialLabel32.AutoSize = true;
            materialLabel32.Depth = 0;
            materialLabel32.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel32.Location = new Point(678, 479);
            materialLabel32.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel32.Name = "materialLabel32";
            materialLabel32.Size = new Size(183, 19);
            materialLabel32.TabIndex = 103;
            materialLabel32.Text = "25.0 to 29.99 - overweight";
            // 
            // materialLabel23
            // 
            materialLabel23.AutoSize = true;
            materialLabel23.Depth = 0;
            materialLabel23.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel23.Location = new Point(678, 460);
            materialLabel23.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel23.Name = "materialLabel23";
            materialLabel23.Size = new Size(196, 19);
            materialLabel23.TabIndex = 102;
            materialLabel23.Text = "18.5 to 24.99 - correct value";
            // 
            // materialLabel25
            // 
            materialLabel25.AutoSize = true;
            materialLabel25.Depth = 0;
            materialLabel25.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel25.Location = new Point(678, 441);
            materialLabel25.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel25.Name = "materialLabel25";
            materialLabel25.Size = new Size(193, 19);
            materialLabel25.TabIndex = 101;
            materialLabel25.Text = "17.0 to 18.49 - underweight";
            // 
            // materialLabel22
            // 
            materialLabel22.AutoSize = true;
            materialLabel22.Depth = 0;
            materialLabel22.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel22.Location = new Point(678, 422);
            materialLabel22.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel22.Name = "materialLabel22";
            materialLabel22.Size = new Size(185, 19);
            materialLabel22.TabIndex = 100;
            materialLabel22.Text = "16.0 to 16.99 - emaciation";
            // 
            // materialLabel21
            // 
            materialLabel21.AutoSize = true;
            materialLabel21.Depth = 0;
            materialLabel21.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel21.Location = new Point(678, 403);
            materialLabel21.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel21.Name = "materialLabel21";
            materialLabel21.Size = new Size(161, 19);
            materialLabel21.TabIndex = 99;
            materialLabel21.Text = "below 16.0 - starvation";
            // 
            // materialLabel20
            // 
            materialLabel20.AutoSize = true;
            materialLabel20.Depth = 0;
            materialLabel20.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel20.Location = new Point(678, 369);
            materialLabel20.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel20.Name = "materialLabel20";
            materialLabel20.Size = new Size(57, 19);
            materialLabel20.TabIndex = 98;
            materialLabel20.Text = "Legend:";
            // 
            // BMIResultLabel
            // 
            BMIResultLabel.Depth = 0;
            BMIResultLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            BMIResultLabel.FontType = Manager.MaterialSkinManager.FontType.H6;
            BMIResultLabel.Location = new Point(867, 326);
            BMIResultLabel.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            BMIResultLabel.Name = "BMIResultLabel";
            BMIResultLabel.Size = new Size(212, 24);
            BMIResultLabel.TabIndex = 97;
            BMIResultLabel.Text = "0.0";
            BMIResultLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // materialLabel19
            // 
            materialLabel19.AutoSize = true;
            materialLabel19.Depth = 0;
            materialLabel19.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel19.FontType = Manager.MaterialSkinManager.FontType.H6;
            materialLabel19.Location = new Point(678, 326);
            materialLabel19.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel19.Name = "materialLabel19";
            materialLabel19.Size = new Size(147, 24);
            materialLabel19.TabIndex = 96;
            materialLabel19.Text = "Your BMI index: ";
            // 
            // CalculateBMIButton
            // 
            CalculateBMIButton.AutoSize = false;
            CalculateBMIButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CalculateBMIButton.CharacterCasing = MaterialButton.CharacterCasingEnum.Normal;
            CalculateBMIButton.Density = MaterialButton.MaterialButtonDensity.Default;
            CalculateBMIButton.Depth = 0;
            CalculateBMIButton.HighEmphasis = true;
            CalculateBMIButton.Icon = null;
            CalculateBMIButton.IconType = MaterialButton.MaterialIconType.Rebase;
            CalculateBMIButton.Location = new Point(678, 265);
            CalculateBMIButton.Margin = new Padding(5, 7, 5, 7);
            CalculateBMIButton.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            CalculateBMIButton.Name = "CalculateBMIButton";
            CalculateBMIButton.NoAccentTextColor = Color.Empty;
            CalculateBMIButton.Size = new Size(399, 36);
            CalculateBMIButton.TabIndex = 95;
            CalculateBMIButton.Text = "Calculate BMI";
            CalculateBMIButton.Type = MaterialButton.MaterialButtonType.Contained;
            CalculateBMIButton.UseAccentColor = false;
            CalculateBMIButton.UseVisualStyleBackColor = true;
            CalculateBMIButton.Click += CalculateBMIButton_Click;
            // 
            // BMIWeightTextBox
            // 
            BMIWeightTextBox.AnimateReadOnly = false;
            BMIWeightTextBox.AutoCompleteMode = AutoCompleteMode.None;
            BMIWeightTextBox.AutoCompleteSource = AutoCompleteSource.None;
            BMIWeightTextBox.BackgroundImageLayout = ImageLayout.None;
            BMIWeightTextBox.CharacterCasing = CharacterCasing.Normal;
            BMIWeightTextBox.Cursor = Cursors.IBeam;
            BMIWeightTextBox.Depth = 0;
            BMIWeightTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            BMIWeightTextBox.HideSelection = true;
            BMIWeightTextBox.Hint = "Weight (kg)";
            BMIWeightTextBox.LeadingIcon = null;
            BMIWeightTextBox.Location = new Point(678, 207);
            BMIWeightTextBox.Margin = new Padding(4, 3, 4, 3);
            BMIWeightTextBox.MaxLength = 50;
            BMIWeightTextBox.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            BMIWeightTextBox.Name = "BMIWeightTextBox";
            BMIWeightTextBox.PasswordChar = '\0';
            BMIWeightTextBox.PrefixSuffixText = null;
            BMIWeightTextBox.ReadOnly = false;
            BMIWeightTextBox.RightToLeft = RightToLeft.No;
            BMIWeightTextBox.SelectedText = "";
            BMIWeightTextBox.SelectionLength = 0;
            BMIWeightTextBox.SelectionStart = 0;
            BMIWeightTextBox.ShortcutsEnabled = true;
            BMIWeightTextBox.Size = new Size(401, 48);
            BMIWeightTextBox.TabIndex = 94;
            BMIWeightTextBox.TabStop = false;
            BMIWeightTextBox.TextAlign = HorizontalAlignment.Left;
            BMIWeightTextBox.TrailingIcon = null;
            BMIWeightTextBox.UseSystemPasswordChar = false;
            BMIWeightTextBox.TextChanged += BMIWeightTextBox_TextChanged;
            // 
            // BMIHeightTextBox
            // 
            BMIHeightTextBox.AnimateReadOnly = false;
            BMIHeightTextBox.AutoCompleteMode = AutoCompleteMode.None;
            BMIHeightTextBox.AutoCompleteSource = AutoCompleteSource.None;
            BMIHeightTextBox.BackgroundImageLayout = ImageLayout.None;
            BMIHeightTextBox.CharacterCasing = CharacterCasing.Normal;
            BMIHeightTextBox.Cursor = Cursors.IBeam;
            BMIHeightTextBox.Depth = 0;
            BMIHeightTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            BMIHeightTextBox.HideSelection = true;
            BMIHeightTextBox.Hint = "Height (cm)";
            BMIHeightTextBox.LeadingIcon = null;
            BMIHeightTextBox.Location = new Point(678, 153);
            BMIHeightTextBox.Margin = new Padding(4, 3, 4, 3);
            BMIHeightTextBox.MaxLength = 50;
            BMIHeightTextBox.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            BMIHeightTextBox.Name = "BMIHeightTextBox";
            BMIHeightTextBox.PasswordChar = '\0';
            BMIHeightTextBox.PrefixSuffixText = null;
            BMIHeightTextBox.ReadOnly = false;
            BMIHeightTextBox.RightToLeft = RightToLeft.No;
            BMIHeightTextBox.SelectedText = "";
            BMIHeightTextBox.SelectionLength = 0;
            BMIHeightTextBox.SelectionStart = 0;
            BMIHeightTextBox.ShortcutsEnabled = true;
            BMIHeightTextBox.Size = new Size(401, 48);
            BMIHeightTextBox.TabIndex = 93;
            BMIHeightTextBox.TabStop = false;
            BMIHeightTextBox.TextAlign = HorizontalAlignment.Left;
            BMIHeightTextBox.TrailingIcon = null;
            BMIHeightTextBox.UseSystemPasswordChar = false;
            BMIHeightTextBox.TextChanged += BMIHeightTextBox_TextChanged;
            // 
            // materialLabel18
            // 
            materialLabel18.Depth = 0;
            materialLabel18.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel18.ForeColor = Color.FromArgb(180, 0, 0, 0);
            materialLabel18.Location = new Point(678, 91);
            materialLabel18.Margin = new Padding(4, 0, 4, 0);
            materialLabel18.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel18.Name = "materialLabel18";
            materialLabel18.Size = new Size(401, 48);
            materialLabel18.TabIndex = 92;
            materialLabel18.Text = "Use the calculator below to determine your BMI";
            // 
            // BMRResultLabel
            // 
            BMRResultLabel.AutoSize = true;
            BMRResultLabel.Depth = 0;
            BMRResultLabel.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            BMRResultLabel.FontType = Manager.MaterialSkinManager.FontType.H6;
            BMRResultLabel.Location = new Point(386, 459);
            BMRResultLabel.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            BMRResultLabel.Name = "BMRResultLabel";
            BMRResultLabel.Size = new Size(37, 24);
            BMRResultLabel.TabIndex = 91;
            BMRResultLabel.Text = "kcal";
            BMRResultLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // materialLabel17
            // 
            materialLabel17.AutoSize = true;
            materialLabel17.Depth = 0;
            materialLabel17.Font = new Font("Roboto Medium", 20F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel17.FontType = Manager.MaterialSkinManager.FontType.H6;
            materialLabel17.Location = new Point(24, 459);
            materialLabel17.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel17.Name = "materialLabel17";
            materialLabel17.Size = new Size(164, 24);
            materialLabel17.TabIndex = 90;
            materialLabel17.Text = "Daily requirement:";
            materialLabel17.TextAlign = ContentAlignment.TopCenter;
            // 
            // CalculateBMRButton
            // 
            CalculateBMRButton.AutoSize = false;
            CalculateBMRButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CalculateBMRButton.CharacterCasing = MaterialButton.CharacterCasingEnum.Normal;
            CalculateBMRButton.Density = MaterialButton.MaterialButtonDensity.Default;
            CalculateBMRButton.Depth = 0;
            CalculateBMRButton.HighEmphasis = true;
            CalculateBMRButton.Icon = null;
            CalculateBMRButton.IconType = MaterialButton.MaterialIconType.Rebase;
            CalculateBMRButton.Location = new Point(24, 403);
            CalculateBMRButton.Margin = new Padding(5, 7, 5, 7);
            CalculateBMRButton.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            CalculateBMRButton.Name = "CalculateBMRButton";
            CalculateBMRButton.NoAccentTextColor = Color.Empty;
            CalculateBMRButton.Size = new Size(399, 36);
            CalculateBMRButton.TabIndex = 89;
            CalculateBMRButton.Text = "Calculate BMR";
            CalculateBMRButton.Type = MaterialButton.MaterialButtonType.Contained;
            CalculateBMRButton.UseAccentColor = false;
            CalculateBMRButton.UseVisualStyleBackColor = true;
            CalculateBMRButton.Click += CalculateBMRButton_Click;
            // 
            // FemaleRadioButton
            // 
            FemaleRadioButton.AutoSize = true;
            FemaleRadioButton.Depth = 0;
            FemaleRadioButton.Location = new Point(22, 359);
            FemaleRadioButton.Margin = new Padding(0);
            FemaleRadioButton.MouseLocation = new Point(-1, -1);
            FemaleRadioButton.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            FemaleRadioButton.Name = "FemaleRadioButton";
            FemaleRadioButton.Ripple = true;
            FemaleRadioButton.Size = new Size(87, 37);
            FemaleRadioButton.TabIndex = 88;
            FemaleRadioButton.TabStop = true;
            FemaleRadioButton.Text = "Female";
            FemaleRadioButton.UseAccentColor = false;
            FemaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // MaleRadioButton
            // 
            MaleRadioButton.AutoSize = true;
            MaleRadioButton.Checked = true;
            MaleRadioButton.Depth = 0;
            MaleRadioButton.Location = new Point(22, 322);
            MaleRadioButton.Margin = new Padding(0);
            MaleRadioButton.MouseLocation = new Point(-1, -1);
            MaleRadioButton.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            MaleRadioButton.Name = "MaleRadioButton";
            MaleRadioButton.Ripple = true;
            MaleRadioButton.Size = new Size(70, 37);
            MaleRadioButton.TabIndex = 87;
            MaleRadioButton.TabStop = true;
            MaleRadioButton.Text = "Male";
            MaleRadioButton.UseAccentColor = false;
            MaleRadioButton.UseVisualStyleBackColor = true;
            // 
            // WeightTextBox
            // 
            WeightTextBox.AnimateReadOnly = false;
            WeightTextBox.AutoCompleteMode = AutoCompleteMode.None;
            WeightTextBox.AutoCompleteSource = AutoCompleteSource.None;
            WeightTextBox.BackgroundImageLayout = ImageLayout.None;
            WeightTextBox.CharacterCasing = CharacterCasing.Normal;
            WeightTextBox.Cursor = Cursors.IBeam;
            WeightTextBox.Depth = 0;
            WeightTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            WeightTextBox.HideSelection = true;
            WeightTextBox.Hint = "Weight (kg)";
            WeightTextBox.LeadingIcon = null;
            WeightTextBox.Location = new Point(22, 261);
            WeightTextBox.Margin = new Padding(4, 3, 4, 3);
            WeightTextBox.MaxLength = 50;
            WeightTextBox.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            WeightTextBox.Name = "WeightTextBox";
            WeightTextBox.PasswordChar = '\0';
            WeightTextBox.PrefixSuffixText = null;
            WeightTextBox.ReadOnly = false;
            WeightTextBox.RightToLeft = RightToLeft.No;
            WeightTextBox.SelectedText = "";
            WeightTextBox.SelectionLength = 0;
            WeightTextBox.SelectionStart = 0;
            WeightTextBox.ShortcutsEnabled = true;
            WeightTextBox.Size = new Size(401, 48);
            WeightTextBox.TabIndex = 86;
            WeightTextBox.TabStop = false;
            WeightTextBox.TextAlign = HorizontalAlignment.Left;
            WeightTextBox.TrailingIcon = null;
            WeightTextBox.UseSystemPasswordChar = false;
            WeightTextBox.TextChanged += WeightTextBox_TextChanged;
            // 
            // AgeTextBox
            // 
            AgeTextBox.AnimateReadOnly = false;
            AgeTextBox.AutoCompleteMode = AutoCompleteMode.None;
            AgeTextBox.AutoCompleteSource = AutoCompleteSource.None;
            AgeTextBox.BackgroundImageLayout = ImageLayout.None;
            AgeTextBox.CharacterCasing = CharacterCasing.Normal;
            AgeTextBox.Cursor = Cursors.IBeam;
            AgeTextBox.Depth = 0;
            AgeTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            AgeTextBox.HideSelection = true;
            AgeTextBox.Hint = "Age (years)";
            AgeTextBox.LeadingIcon = null;
            AgeTextBox.Location = new Point(22, 207);
            AgeTextBox.Margin = new Padding(4, 3, 4, 3);
            AgeTextBox.MaxLength = 50;
            AgeTextBox.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.PasswordChar = '\0';
            AgeTextBox.PrefixSuffixText = null;
            AgeTextBox.ReadOnly = false;
            AgeTextBox.RightToLeft = RightToLeft.No;
            AgeTextBox.SelectedText = "";
            AgeTextBox.SelectionLength = 0;
            AgeTextBox.SelectionStart = 0;
            AgeTextBox.ShortcutsEnabled = true;
            AgeTextBox.Size = new Size(399, 48);
            AgeTextBox.TabIndex = 85;
            AgeTextBox.TabStop = false;
            AgeTextBox.TextAlign = HorizontalAlignment.Left;
            AgeTextBox.TrailingIcon = null;
            AgeTextBox.UseSystemPasswordChar = false;
            AgeTextBox.TextChanged += AgeTextBox_TextChanged;
            // 
            // HeightTextBox
            // 
            HeightTextBox.AnimateReadOnly = false;
            HeightTextBox.AutoCompleteMode = AutoCompleteMode.None;
            HeightTextBox.AutoCompleteSource = AutoCompleteSource.None;
            HeightTextBox.BackgroundImageLayout = ImageLayout.None;
            HeightTextBox.CharacterCasing = CharacterCasing.Normal;
            HeightTextBox.Cursor = Cursors.IBeam;
            HeightTextBox.Depth = 0;
            HeightTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            HeightTextBox.HideSelection = true;
            HeightTextBox.Hint = "Height (cm)";
            HeightTextBox.LeadingIcon = null;
            HeightTextBox.Location = new Point(22, 153);
            HeightTextBox.Margin = new Padding(4, 3, 4, 3);
            HeightTextBox.MaxLength = 50;
            HeightTextBox.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            HeightTextBox.Name = "HeightTextBox";
            HeightTextBox.PasswordChar = '\0';
            HeightTextBox.PrefixSuffixText = null;
            HeightTextBox.ReadOnly = false;
            HeightTextBox.RightToLeft = RightToLeft.No;
            HeightTextBox.SelectedText = "";
            HeightTextBox.SelectionLength = 0;
            HeightTextBox.SelectionStart = 0;
            HeightTextBox.ShortcutsEnabled = true;
            HeightTextBox.Size = new Size(401, 48);
            HeightTextBox.TabIndex = 84;
            HeightTextBox.TabStop = false;
            HeightTextBox.TextAlign = HorizontalAlignment.Left;
            HeightTextBox.TrailingIcon = null;
            HeightTextBox.UseSystemPasswordChar = false;
            HeightTextBox.TextChanged += HeightTextBox_TextChanged;
            // 
            // materialLabel16
            // 
            materialLabel16.AutoSize = true;
            materialLabel16.Depth = 0;
            materialLabel16.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel16.FontType = Manager.MaterialSkinManager.FontType.H3;
            materialLabel16.Location = new Point(678, 20);
            materialLabel16.Margin = new Padding(4, 0, 4, 0);
            materialLabel16.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel16.Name = "materialLabel16";
            materialLabel16.Size = new Size(309, 58);
            materialLabel16.TabIndex = 69;
            materialLabel16.Text = "BMI calculator";
            // 
            // materialLabel15
            // 
            materialLabel15.Depth = 0;
            materialLabel15.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel15.ForeColor = Color.FromArgb(180, 0, 0, 0);
            materialLabel15.Location = new Point(22, 91);
            materialLabel15.Margin = new Padding(4, 0, 4, 0);
            materialLabel15.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel15.Name = "materialLabel15";
            materialLabel15.Size = new Size(401, 48);
            materialLabel15.TabIndex = 68;
            materialLabel15.Text = "Use the calculator below to determine your daily calorie requirements (BMR)";
            // 
            // materialLabel7
            // 
            materialLabel7.AutoSize = true;
            materialLabel7.Depth = 0;
            materialLabel7.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel7.FontType = Manager.MaterialSkinManager.FontType.H3;
            materialLabel7.Location = new Point(24, 20);
            materialLabel7.Margin = new Padding(4, 0, 4, 0);
            materialLabel7.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel7.Name = "materialLabel7";
            materialLabel7.Size = new Size(326, 58);
            materialLabel7.TabIndex = 67;
            materialLabel7.Text = "BMR calculator";
            // 
            // DiagramPage
            // 
            DiagramPage.BackColor = Color.White;
            DiagramPage.Controls.Add(materialLabel33);
            DiagramPage.Controls.Add(WeightPlot);
            DiagramPage.Controls.Add(RemoveFromWeightDiagramButton);
            DiagramPage.Controls.Add(AddDiagramButton);
            DiagramPage.Controls.Add(AddDiagramWeigth);
            DiagramPage.Controls.Add(AddDiagramDate);
            DiagramPage.Controls.Add(DiagramItemsListView);
            DiagramPage.Controls.Add(materialLabel29);
            DiagramPage.ImageKey = "monitoring_24dp_E8EAED_FILL0_wght300_GRAD0_opsz24.png";
            DiagramPage.Location = new Point(4, 31);
            DiagramPage.Margin = new Padding(4, 3, 4, 3);
            DiagramPage.Name = "DiagramPage";
            DiagramPage.Padding = new Padding(4, 3, 4, 3);
            DiagramPage.Size = new Size(1184, 648);
            DiagramPage.TabIndex = 4;
            DiagramPage.Text = "Weight diagram";
            // 
            // materialLabel33
            // 
            materialLabel33.Depth = 0;
            materialLabel33.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel33.ForeColor = Color.FromArgb(180, 0, 0, 0);
            materialLabel33.Location = new Point(24, 87);
            materialLabel33.Margin = new Padding(4, 0, 4, 0);
            materialLabel33.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel33.Name = "materialLabel33";
            materialLabel33.Size = new Size(442, 48);
            materialLabel33.TabIndex = 99;
            materialLabel33.Text = "The weight chart below allows you to monitor your weight on an ongoing basis and analyse changes in the long term.";
            // 
            // WeightPlot
            // 
            WeightPlot.DisplayScale = 1F;
            WeightPlot.Location = new Point(24, 155);
            WeightPlot.Name = "WeightPlot";
            WeightPlot.Size = new Size(736, 408);
            WeightPlot.TabIndex = 98;
            // 
            // RemoveFromWeightDiagramButton
            // 
            RemoveFromWeightDiagramButton.AutoSize = false;
            RemoveFromWeightDiagramButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RemoveFromWeightDiagramButton.CharacterCasing = MaterialButton.CharacterCasingEnum.Normal;
            RemoveFromWeightDiagramButton.Density = MaterialButton.MaterialButtonDensity.Default;
            RemoveFromWeightDiagramButton.Depth = 0;
            RemoveFromWeightDiagramButton.HighEmphasis = true;
            RemoveFromWeightDiagramButton.Icon = null;
            RemoveFromWeightDiagramButton.IconType = MaterialButton.MaterialIconType.Rebase;
            RemoveFromWeightDiagramButton.Location = new Point(990, 435);
            RemoveFromWeightDiagramButton.Margin = new Padding(5, 7, 5, 7);
            RemoveFromWeightDiagramButton.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            RemoveFromWeightDiagramButton.Name = "RemoveFromWeightDiagramButton";
            RemoveFromWeightDiagramButton.NoAccentTextColor = Color.Empty;
            RemoveFromWeightDiagramButton.Size = new Size(102, 39);
            RemoveFromWeightDiagramButton.TabIndex = 97;
            RemoveFromWeightDiagramButton.Text = "Delete from diagram";
            RemoveFromWeightDiagramButton.Type = MaterialButton.MaterialButtonType.Contained;
            RemoveFromWeightDiagramButton.UseAccentColor = true;
            RemoveFromWeightDiagramButton.UseVisualStyleBackColor = true;
            RemoveFromWeightDiagramButton.Click += RemoveFromWeightDiagramButton_Click;
            // 
            // AddDiagramButton
            // 
            AddDiagramButton.AutoSize = false;
            AddDiagramButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            AddDiagramButton.CharacterCasing = MaterialButton.CharacterCasingEnum.Normal;
            AddDiagramButton.Density = MaterialButton.MaterialButtonDensity.Default;
            AddDiagramButton.Depth = 0;
            AddDiagramButton.HighEmphasis = true;
            AddDiagramButton.Icon = null;
            AddDiagramButton.IconType = MaterialButton.MaterialIconType.Rebase;
            AddDiagramButton.Location = new Point(990, 480);
            AddDiagramButton.Margin = new Padding(5, 7, 5, 7);
            AddDiagramButton.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            AddDiagramButton.Name = "AddDiagramButton";
            AddDiagramButton.NoAccentTextColor = Color.Empty;
            AddDiagramButton.Size = new Size(102, 83);
            AddDiagramButton.TabIndex = 96;
            AddDiagramButton.Text = "Add to diagram";
            AddDiagramButton.Type = MaterialButton.MaterialButtonType.Contained;
            AddDiagramButton.UseAccentColor = false;
            AddDiagramButton.UseVisualStyleBackColor = true;
            AddDiagramButton.Click += AddDiagramButton_Click;
            // 
            // AddDiagramWeigth
            // 
            AddDiagramWeigth.AnimateReadOnly = false;
            AddDiagramWeigth.AutoCompleteMode = AutoCompleteMode.None;
            AddDiagramWeigth.AutoCompleteSource = AutoCompleteSource.None;
            AddDiagramWeigth.BackgroundImageLayout = ImageLayout.None;
            AddDiagramWeigth.CharacterCasing = CharacterCasing.Normal;
            AddDiagramWeigth.Cursor = Cursors.IBeam;
            AddDiagramWeigth.Depth = 0;
            AddDiagramWeigth.Font = new Font("Microsoft Sans Serif", 12F);
            AddDiagramWeigth.HideSelection = true;
            AddDiagramWeigth.Hint = "Weight (kg)";
            AddDiagramWeigth.LeadingIcon = null;
            AddDiagramWeigth.Location = new Point(779, 515);
            AddDiagramWeigth.Margin = new Padding(4, 3, 4, 3);
            AddDiagramWeigth.MaxLength = 50;
            AddDiagramWeigth.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            AddDiagramWeigth.Name = "AddDiagramWeigth";
            AddDiagramWeigth.PasswordChar = '\0';
            AddDiagramWeigth.PrefixSuffixText = null;
            AddDiagramWeigth.ReadOnly = false;
            AddDiagramWeigth.RightToLeft = RightToLeft.No;
            AddDiagramWeigth.SelectedText = "";
            AddDiagramWeigth.SelectionLength = 0;
            AddDiagramWeigth.SelectionStart = 0;
            AddDiagramWeigth.ShortcutsEnabled = true;
            AddDiagramWeigth.Size = new Size(203, 48);
            AddDiagramWeigth.TabIndex = 95;
            AddDiagramWeigth.TabStop = false;
            AddDiagramWeigth.TextAlign = HorizontalAlignment.Left;
            AddDiagramWeigth.TrailingIcon = null;
            AddDiagramWeigth.UseSystemPasswordChar = false;
            AddDiagramWeigth.TextChanged += AddDiagramWeigth_TextChanged;
            // 
            // AddDiagramDate
            // 
            AddDiagramDate.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            AddDiagramDate.Location = new Point(779, 480);
            AddDiagramDate.MaximumSize = new Size(203, 48);
            AddDiagramDate.MinimumSize = new Size(0, 29);
            AddDiagramDate.Name = "AddDiagramDate";
            AddDiagramDate.Size = new Size(203, 29);
            AddDiagramDate.TabIndex = 66;
            // 
            // DiagramItemsListView
            // 
            DiagramItemsListView.AllowColumnReorder = true;
            DiagramItemsListView.AutoSizeTable = false;
            DiagramItemsListView.BackColor = Color.FromArgb(255, 255, 255);
            DiagramItemsListView.BorderStyle = BorderStyle.None;
            DiagramItemsListView.Columns.AddRange(new ColumnHeader[] { DateHeader, WeightHeader });
            DiagramItemsListView.Depth = 0;
            DiagramItemsListView.Font = new Font("Microsoft Sans Serif", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            DiagramItemsListView.FullRowSelect = true;
            DiagramItemsListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            DiagramItemsListView.Location = new Point(779, 274);
            DiagramItemsListView.Margin = new Padding(4, 3, 4, 3);
            DiagramItemsListView.MinimumSize = new Size(200, 200);
            DiagramItemsListView.MouseLocation = new Point(-1, -1);
            DiagramItemsListView.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            DiagramItemsListView.MultiSelect = false;
            DiagramItemsListView.Name = "DiagramItemsListView";
            DiagramItemsListView.OwnerDraw = true;
            DiagramItemsListView.Size = new Size(203, 200);
            DiagramItemsListView.TabIndex = 65;
            DiagramItemsListView.UseCompatibleStateImageBehavior = false;
            DiagramItemsListView.View = View.Details;
            // 
            // DateHeader
            // 
            DateHeader.Text = "Date";
            DateHeader.Width = 100;
            // 
            // WeightHeader
            // 
            WeightHeader.Text = "Weight (kg)";
            WeightHeader.Width = 110;
            // 
            // materialLabel29
            // 
            materialLabel29.AutoSize = true;
            materialLabel29.Depth = 0;
            materialLabel29.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel29.FontType = Manager.MaterialSkinManager.FontType.H3;
            materialLabel29.Location = new Point(24, 20);
            materialLabel29.Margin = new Padding(4, 0, 4, 0);
            materialLabel29.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel29.Name = "materialLabel29";
            materialLabel29.Size = new Size(338, 58);
            materialLabel29.TabIndex = 64;
            materialLabel29.Text = "Weight diagram";
            // 
            // ProfilePage
            // 
            ProfilePage.BackColor = Color.White;
            ProfilePage.Controls.Add(LogoutButton);
            ProfilePage.Controls.Add(PostalCodeTextBox);
            ProfilePage.Controls.Add(materialSwitch10);
            ProfilePage.Controls.Add(NewPassAgainTextBox);
            ProfilePage.Controls.Add(NewPassTextBox);
            ProfilePage.Controls.Add(CurrentPassTextBox);
            ProfilePage.Controls.Add(CityTextBox);
            ProfilePage.Controls.Add(StreetNoTextBox);
            ProfilePage.Controls.Add(StreetTextBox);
            ProfilePage.Controls.Add(SaveChangesButton);
            ProfilePage.Controls.Add(ChangePassButton);
            ProfilePage.Controls.Add(SurnameTextBox);
            ProfilePage.Controls.Add(NameTextBox);
            ProfilePage.Controls.Add(PhoneTextBox);
            ProfilePage.Controls.Add(EmailTextBox);
            ProfilePage.Controls.Add(materialLabel27);
            ProfilePage.Controls.Add(materialLabel56);
            ProfilePage.ImageKey = "person_24dp_E8EAED_FILL0_wght300_GRAD0_opsz24.png";
            ProfilePage.Location = new Point(4, 31);
            ProfilePage.Margin = new Padding(4, 3, 4, 3);
            ProfilePage.Name = "ProfilePage";
            ProfilePage.Padding = new Padding(4, 3, 4, 3);
            ProfilePage.Size = new Size(1184, 648);
            ProfilePage.TabIndex = 2;
            ProfilePage.Text = "User profile";
            ProfilePage.Enter += ProfilePage_Enter;
            // 
            // LogoutButton
            // 
            LogoutButton.AutoSize = false;
            LogoutButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LogoutButton.CharacterCasing = MaterialButton.CharacterCasingEnum.Normal;
            LogoutButton.Density = MaterialButton.MaterialButtonDensity.Default;
            LogoutButton.Depth = 0;
            LogoutButton.HighEmphasis = true;
            LogoutButton.Icon = null;
            LogoutButton.IconType = MaterialButton.MaterialIconType.Rebase;
            LogoutButton.Location = new Point(662, 529);
            LogoutButton.Margin = new Padding(5, 7, 5, 7);
            LogoutButton.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            LogoutButton.Name = "LogoutButton";
            LogoutButton.NoAccentTextColor = Color.Empty;
            LogoutButton.Size = new Size(130, 36);
            LogoutButton.TabIndex = 95;
            LogoutButton.Text = "Logout";
            LogoutButton.Type = MaterialButton.MaterialButtonType.Contained;
            LogoutButton.UseAccentColor = true;
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // PostalCodeTextBox
            // 
            PostalCodeTextBox.AllowPromptAsInput = true;
            PostalCodeTextBox.AnimateReadOnly = false;
            PostalCodeTextBox.AsciiOnly = false;
            PostalCodeTextBox.BackgroundImageLayout = ImageLayout.None;
            PostalCodeTextBox.BeepOnError = false;
            PostalCodeTextBox.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            PostalCodeTextBox.Depth = 0;
            PostalCodeTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            PostalCodeTextBox.HidePromptOnLeave = true;
            PostalCodeTextBox.HideSelection = false;
            PostalCodeTextBox.Hint = "Postal code";
            PostalCodeTextBox.InsertKeyMode = InsertKeyMode.Default;
            PostalCodeTextBox.LeadingIcon = null;
            PostalCodeTextBox.Location = new Point(425, 271);
            PostalCodeTextBox.Margin = new Padding(4, 3, 4, 3);
            PostalCodeTextBox.Mask = "00-000";
            PostalCodeTextBox.MaxLength = 32767;
            PostalCodeTextBox.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            PostalCodeTextBox.Name = "PostalCodeTextBox";
            PostalCodeTextBox.PasswordChar = '\0';
            PostalCodeTextBox.PrefixSuffixText = null;
            PostalCodeTextBox.PromptChar = '_';
            PostalCodeTextBox.ReadOnly = false;
            PostalCodeTextBox.RejectInputOnFirstFailure = true;
            PostalCodeTextBox.ResetOnPrompt = true;
            PostalCodeTextBox.ResetOnSpace = true;
            PostalCodeTextBox.RightToLeft = RightToLeft.No;
            PostalCodeTextBox.SelectedText = "";
            PostalCodeTextBox.SelectionLength = 0;
            PostalCodeTextBox.SelectionStart = 3;
            PostalCodeTextBox.ShortcutsEnabled = true;
            PostalCodeTextBox.Size = new Size(367, 48);
            PostalCodeTextBox.SkipLiterals = true;
            PostalCodeTextBox.TabIndex = 94;
            PostalCodeTextBox.TabStop = false;
            PostalCodeTextBox.Text = "  -";
            PostalCodeTextBox.TextAlign = HorizontalAlignment.Left;
            PostalCodeTextBox.TextMaskFormat = MaskFormat.IncludeLiterals;
            PostalCodeTextBox.TrailingIcon = null;
            PostalCodeTextBox.UseSystemPasswordChar = false;
            PostalCodeTextBox.ValidatingType = null;
            // 
            // materialSwitch10
            // 
            materialSwitch10.AutoSize = true;
            materialSwitch10.Depth = 0;
            materialSwitch10.Location = new Point(418, 474);
            materialSwitch10.Margin = new Padding(0);
            materialSwitch10.MouseLocation = new Point(-1, -1);
            materialSwitch10.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialSwitch10.Name = "materialSwitch10";
            materialSwitch10.Ripple = true;
            materialSwitch10.Size = new Size(179, 37);
            materialSwitch10.TabIndex = 93;
            materialSwitch10.Text = "Show passwords";
            materialSwitch10.UseAccentColor = false;
            materialSwitch10.UseVisualStyleBackColor = true;
            materialSwitch10.CheckedChanged += materialSwitch10_CheckedChanged;
            // 
            // NewPassAgainTextBox
            // 
            NewPassAgainTextBox.AnimateReadOnly = false;
            NewPassAgainTextBox.AutoCompleteMode = AutoCompleteMode.None;
            NewPassAgainTextBox.AutoCompleteSource = AutoCompleteSource.None;
            NewPassAgainTextBox.BackgroundImageLayout = ImageLayout.None;
            NewPassAgainTextBox.CharacterCasing = CharacterCasing.Normal;
            NewPassAgainTextBox.Cursor = Cursors.IBeam;
            NewPassAgainTextBox.Depth = 0;
            NewPassAgainTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            NewPassAgainTextBox.HideSelection = true;
            NewPassAgainTextBox.Hint = "Repeat new password";
            NewPassAgainTextBox.LeadingIcon = null;
            NewPassAgainTextBox.Location = new Point(29, 517);
            NewPassAgainTextBox.Margin = new Padding(4, 3, 4, 3);
            NewPassAgainTextBox.MaxLength = 50;
            NewPassAgainTextBox.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            NewPassAgainTextBox.Name = "NewPassAgainTextBox";
            NewPassAgainTextBox.PasswordChar = '●';
            NewPassAgainTextBox.PrefixSuffixText = null;
            NewPassAgainTextBox.ReadOnly = false;
            NewPassAgainTextBox.RightToLeft = RightToLeft.No;
            NewPassAgainTextBox.SelectedText = "";
            NewPassAgainTextBox.SelectionLength = 0;
            NewPassAgainTextBox.SelectionStart = 0;
            NewPassAgainTextBox.ShortcutsEnabled = true;
            NewPassAgainTextBox.Size = new Size(367, 48);
            NewPassAgainTextBox.TabIndex = 92;
            NewPassAgainTextBox.TabStop = false;
            NewPassAgainTextBox.TextAlign = HorizontalAlignment.Left;
            NewPassAgainTextBox.TrailingIcon = null;
            NewPassAgainTextBox.UseSystemPasswordChar = true;
            NewPassAgainTextBox.TextChanged += NewPassAgainTextBox_TextChanged;
            // 
            // NewPassTextBox
            // 
            NewPassTextBox.AnimateReadOnly = false;
            NewPassTextBox.AutoCompleteMode = AutoCompleteMode.None;
            NewPassTextBox.AutoCompleteSource = AutoCompleteSource.None;
            NewPassTextBox.BackgroundImageLayout = ImageLayout.None;
            NewPassTextBox.CharacterCasing = CharacterCasing.Normal;
            NewPassTextBox.Cursor = Cursors.IBeam;
            NewPassTextBox.Depth = 0;
            NewPassTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            NewPassTextBox.HideSelection = true;
            NewPassTextBox.Hint = "New password";
            NewPassTextBox.LeadingIcon = null;
            NewPassTextBox.Location = new Point(29, 463);
            NewPassTextBox.Margin = new Padding(4, 3, 4, 3);
            NewPassTextBox.MaxLength = 50;
            NewPassTextBox.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            NewPassTextBox.Name = "NewPassTextBox";
            NewPassTextBox.PasswordChar = '●';
            NewPassTextBox.PrefixSuffixText = null;
            NewPassTextBox.ReadOnly = false;
            NewPassTextBox.RightToLeft = RightToLeft.No;
            NewPassTextBox.SelectedText = "";
            NewPassTextBox.SelectionLength = 0;
            NewPassTextBox.SelectionStart = 0;
            NewPassTextBox.ShortcutsEnabled = true;
            NewPassTextBox.Size = new Size(367, 48);
            NewPassTextBox.TabIndex = 91;
            NewPassTextBox.TabStop = false;
            NewPassTextBox.TextAlign = HorizontalAlignment.Left;
            NewPassTextBox.TrailingIcon = null;
            NewPassTextBox.UseSystemPasswordChar = true;
            NewPassTextBox.TextChanged += NewPassTextBox_TextChanged;
            // 
            // CurrentPassTextBox
            // 
            CurrentPassTextBox.AnimateReadOnly = false;
            CurrentPassTextBox.AutoCompleteMode = AutoCompleteMode.None;
            CurrentPassTextBox.AutoCompleteSource = AutoCompleteSource.None;
            CurrentPassTextBox.BackgroundImageLayout = ImageLayout.None;
            CurrentPassTextBox.CharacterCasing = CharacterCasing.Normal;
            CurrentPassTextBox.Cursor = Cursors.IBeam;
            CurrentPassTextBox.Depth = 0;
            CurrentPassTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            CurrentPassTextBox.HideSelection = true;
            CurrentPassTextBox.Hint = "Current password";
            CurrentPassTextBox.LeadingIcon = null;
            CurrentPassTextBox.Location = new Point(29, 409);
            CurrentPassTextBox.Margin = new Padding(4, 3, 4, 3);
            CurrentPassTextBox.MaxLength = 50;
            CurrentPassTextBox.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            CurrentPassTextBox.Name = "CurrentPassTextBox";
            CurrentPassTextBox.PasswordChar = '●';
            CurrentPassTextBox.PrefixSuffixText = null;
            CurrentPassTextBox.ReadOnly = false;
            CurrentPassTextBox.RightToLeft = RightToLeft.No;
            CurrentPassTextBox.SelectedText = "";
            CurrentPassTextBox.SelectionLength = 0;
            CurrentPassTextBox.SelectionStart = 0;
            CurrentPassTextBox.ShortcutsEnabled = true;
            CurrentPassTextBox.Size = new Size(367, 48);
            CurrentPassTextBox.TabIndex = 90;
            CurrentPassTextBox.TabStop = false;
            CurrentPassTextBox.TextAlign = HorizontalAlignment.Left;
            CurrentPassTextBox.TrailingIcon = null;
            CurrentPassTextBox.UseSystemPasswordChar = true;
            CurrentPassTextBox.TextChanged += CurrentPassTextBox_TextChanged;
            // 
            // CityTextBox
            // 
            CityTextBox.AnimateReadOnly = false;
            CityTextBox.AutoCompleteMode = AutoCompleteMode.None;
            CityTextBox.AutoCompleteSource = AutoCompleteSource.None;
            CityTextBox.BackgroundImageLayout = ImageLayout.None;
            CityTextBox.CharacterCasing = CharacterCasing.Normal;
            CityTextBox.Cursor = Cursors.IBeam;
            CityTextBox.Depth = 0;
            CityTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            CityTextBox.HideSelection = true;
            CityTextBox.Hint = "City";
            CityTextBox.LeadingIcon = null;
            CityTextBox.Location = new Point(425, 325);
            CityTextBox.Margin = new Padding(4, 3, 4, 3);
            CityTextBox.MaxLength = 50;
            CityTextBox.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            CityTextBox.Name = "CityTextBox";
            CityTextBox.PasswordChar = '\0';
            CityTextBox.PrefixSuffixText = null;
            CityTextBox.ReadOnly = false;
            CityTextBox.RightToLeft = RightToLeft.No;
            CityTextBox.SelectedText = "";
            CityTextBox.SelectionLength = 0;
            CityTextBox.SelectionStart = 0;
            CityTextBox.ShortcutsEnabled = true;
            CityTextBox.Size = new Size(367, 48);
            CityTextBox.TabIndex = 89;
            CityTextBox.TabStop = false;
            CityTextBox.TextAlign = HorizontalAlignment.Left;
            CityTextBox.TrailingIcon = null;
            CityTextBox.UseSystemPasswordChar = false;
            // 
            // StreetNoTextBox
            // 
            StreetNoTextBox.AnimateReadOnly = false;
            StreetNoTextBox.AutoCompleteMode = AutoCompleteMode.None;
            StreetNoTextBox.AutoCompleteSource = AutoCompleteSource.None;
            StreetNoTextBox.BackgroundImageLayout = ImageLayout.None;
            StreetNoTextBox.CharacterCasing = CharacterCasing.Normal;
            StreetNoTextBox.Cursor = Cursors.IBeam;
            StreetNoTextBox.Depth = 0;
            StreetNoTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            StreetNoTextBox.HideSelection = true;
            StreetNoTextBox.Hint = "Street No.";
            StreetNoTextBox.LeadingIcon = null;
            StreetNoTextBox.Location = new Point(425, 217);
            StreetNoTextBox.Margin = new Padding(4, 3, 4, 3);
            StreetNoTextBox.MaxLength = 50;
            StreetNoTextBox.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            StreetNoTextBox.Name = "StreetNoTextBox";
            StreetNoTextBox.PasswordChar = '\0';
            StreetNoTextBox.PrefixSuffixText = null;
            StreetNoTextBox.ReadOnly = false;
            StreetNoTextBox.RightToLeft = RightToLeft.No;
            StreetNoTextBox.SelectedText = "";
            StreetNoTextBox.SelectionLength = 0;
            StreetNoTextBox.SelectionStart = 0;
            StreetNoTextBox.ShortcutsEnabled = true;
            StreetNoTextBox.Size = new Size(367, 48);
            StreetNoTextBox.TabIndex = 87;
            StreetNoTextBox.TabStop = false;
            StreetNoTextBox.TextAlign = HorizontalAlignment.Left;
            StreetNoTextBox.TrailingIcon = null;
            StreetNoTextBox.UseSystemPasswordChar = false;
            // 
            // StreetTextBox
            // 
            StreetTextBox.AnimateReadOnly = false;
            StreetTextBox.AutoCompleteMode = AutoCompleteMode.None;
            StreetTextBox.AutoCompleteSource = AutoCompleteSource.None;
            StreetTextBox.BackgroundImageLayout = ImageLayout.None;
            StreetTextBox.CharacterCasing = CharacterCasing.Normal;
            StreetTextBox.Cursor = Cursors.IBeam;
            StreetTextBox.Depth = 0;
            StreetTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            StreetTextBox.HideSelection = true;
            StreetTextBox.Hint = "Street";
            StreetTextBox.LeadingIcon = null;
            StreetTextBox.Location = new Point(425, 163);
            StreetTextBox.Margin = new Padding(4, 3, 4, 3);
            StreetTextBox.MaxLength = 50;
            StreetTextBox.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            StreetTextBox.Name = "StreetTextBox";
            StreetTextBox.PasswordChar = '\0';
            StreetTextBox.PrefixSuffixText = null;
            StreetTextBox.ReadOnly = false;
            StreetTextBox.RightToLeft = RightToLeft.No;
            StreetTextBox.SelectedText = "";
            StreetTextBox.SelectionLength = 0;
            StreetTextBox.SelectionStart = 0;
            StreetTextBox.ShortcutsEnabled = true;
            StreetTextBox.Size = new Size(367, 48);
            StreetTextBox.TabIndex = 86;
            StreetTextBox.TabStop = false;
            StreetTextBox.TextAlign = HorizontalAlignment.Left;
            StreetTextBox.TrailingIcon = null;
            StreetTextBox.UseSystemPasswordChar = false;
            // 
            // SaveChangesButton
            // 
            SaveChangesButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SaveChangesButton.CharacterCasing = MaterialButton.CharacterCasingEnum.Normal;
            SaveChangesButton.Density = MaterialButton.MaterialButtonDensity.Default;
            SaveChangesButton.Depth = 0;
            SaveChangesButton.HighEmphasis = true;
            SaveChangesButton.Icon = null;
            SaveChangesButton.IconType = MaterialButton.MaterialIconType.Rebase;
            SaveChangesButton.Location = new Point(800, 337);
            SaveChangesButton.Margin = new Padding(4, 6, 4, 6);
            SaveChangesButton.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            SaveChangesButton.Name = "SaveChangesButton";
            SaveChangesButton.NoAccentTextColor = Color.Empty;
            SaveChangesButton.Size = new Size(129, 36);
            SaveChangesButton.TabIndex = 85;
            SaveChangesButton.Text = "Save changes";
            SaveChangesButton.Type = MaterialButton.MaterialButtonType.Contained;
            SaveChangesButton.UseAccentColor = false;
            SaveChangesButton.UseVisualStyleBackColor = true;
            SaveChangesButton.Click += SaveChangesButton_Click;
            // 
            // ChangePassButton
            // 
            ChangePassButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ChangePassButton.CharacterCasing = MaterialButton.CharacterCasingEnum.Normal;
            ChangePassButton.Density = MaterialButton.MaterialButtonDensity.Default;
            ChangePassButton.Depth = 0;
            ChangePassButton.Enabled = false;
            ChangePassButton.HighEmphasis = true;
            ChangePassButton.Icon = null;
            ChangePassButton.IconType = MaterialButton.MaterialIconType.Rebase;
            ChangePassButton.Location = new Point(425, 529);
            ChangePassButton.Margin = new Padding(4, 6, 4, 6);
            ChangePassButton.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ChangePassButton.Name = "ChangePassButton";
            ChangePassButton.NoAccentTextColor = Color.Empty;
            ChangePassButton.Size = new Size(163, 36);
            ChangePassButton.TabIndex = 84;
            ChangePassButton.Text = "Change password";
            ChangePassButton.Type = MaterialButton.MaterialButtonType.Outlined;
            ChangePassButton.UseAccentColor = true;
            ChangePassButton.UseVisualStyleBackColor = true;
            ChangePassButton.Click += ChangePassButton_Click;
            // 
            // SurnameTextBox
            // 
            SurnameTextBox.AnimateReadOnly = false;
            SurnameTextBox.AutoCompleteMode = AutoCompleteMode.None;
            SurnameTextBox.AutoCompleteSource = AutoCompleteSource.None;
            SurnameTextBox.BackgroundImageLayout = ImageLayout.None;
            SurnameTextBox.CharacterCasing = CharacterCasing.Normal;
            SurnameTextBox.Cursor = Cursors.IBeam;
            SurnameTextBox.Depth = 0;
            SurnameTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            SurnameTextBox.HideSelection = true;
            SurnameTextBox.Hint = "Surname";
            SurnameTextBox.LeadingIcon = null;
            SurnameTextBox.Location = new Point(29, 271);
            SurnameTextBox.Margin = new Padding(4, 3, 4, 3);
            SurnameTextBox.MaxLength = 50;
            SurnameTextBox.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            SurnameTextBox.Name = "SurnameTextBox";
            SurnameTextBox.PasswordChar = '\0';
            SurnameTextBox.PrefixSuffixText = null;
            SurnameTextBox.ReadOnly = false;
            SurnameTextBox.RightToLeft = RightToLeft.No;
            SurnameTextBox.SelectedText = "";
            SurnameTextBox.SelectionLength = 0;
            SurnameTextBox.SelectionStart = 0;
            SurnameTextBox.ShortcutsEnabled = true;
            SurnameTextBox.Size = new Size(367, 48);
            SurnameTextBox.TabIndex = 83;
            SurnameTextBox.TabStop = false;
            SurnameTextBox.TextAlign = HorizontalAlignment.Left;
            SurnameTextBox.TrailingIcon = null;
            SurnameTextBox.UseSystemPasswordChar = false;
            // 
            // NameTextBox
            // 
            NameTextBox.AnimateReadOnly = false;
            NameTextBox.AutoCompleteMode = AutoCompleteMode.None;
            NameTextBox.AutoCompleteSource = AutoCompleteSource.None;
            NameTextBox.BackgroundImageLayout = ImageLayout.None;
            NameTextBox.CharacterCasing = CharacterCasing.Normal;
            NameTextBox.Cursor = Cursors.IBeam;
            NameTextBox.Depth = 0;
            NameTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            NameTextBox.HideSelection = true;
            NameTextBox.Hint = "Name";
            NameTextBox.LeadingIcon = null;
            NameTextBox.Location = new Point(29, 217);
            NameTextBox.Margin = new Padding(4, 3, 4, 3);
            NameTextBox.MaxLength = 50;
            NameTextBox.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.PasswordChar = '\0';
            NameTextBox.PrefixSuffixText = null;
            NameTextBox.ReadOnly = false;
            NameTextBox.RightToLeft = RightToLeft.No;
            NameTextBox.SelectedText = "";
            NameTextBox.SelectionLength = 0;
            NameTextBox.SelectionStart = 0;
            NameTextBox.ShortcutsEnabled = true;
            NameTextBox.Size = new Size(367, 48);
            NameTextBox.TabIndex = 82;
            NameTextBox.TabStop = false;
            NameTextBox.TextAlign = HorizontalAlignment.Left;
            NameTextBox.TrailingIcon = null;
            NameTextBox.UseSystemPasswordChar = false;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.AllowPromptAsInput = true;
            PhoneTextBox.AnimateReadOnly = false;
            PhoneTextBox.AsciiOnly = false;
            PhoneTextBox.BackgroundImageLayout = ImageLayout.None;
            PhoneTextBox.BeepOnError = false;
            PhoneTextBox.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            PhoneTextBox.Depth = 0;
            PhoneTextBox.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            PhoneTextBox.HidePromptOnLeave = true;
            PhoneTextBox.HideSelection = false;
            PhoneTextBox.Hint = "Phone number";
            PhoneTextBox.InsertKeyMode = InsertKeyMode.Default;
            PhoneTextBox.LeadingIcon = null;
            PhoneTextBox.Location = new Point(29, 325);
            PhoneTextBox.Margin = new Padding(4, 3, 4, 3);
            PhoneTextBox.Mask = "000-000-000";
            PhoneTextBox.MaxLength = 32767;
            PhoneTextBox.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.PasswordChar = '\0';
            PhoneTextBox.PrefixSuffixText = null;
            PhoneTextBox.PromptChar = '_';
            PhoneTextBox.ReadOnly = false;
            PhoneTextBox.RejectInputOnFirstFailure = true;
            PhoneTextBox.ResetOnPrompt = true;
            PhoneTextBox.ResetOnSpace = true;
            PhoneTextBox.RightToLeft = RightToLeft.No;
            PhoneTextBox.SelectedText = "";
            PhoneTextBox.SelectionLength = 0;
            PhoneTextBox.SelectionStart = 8;
            PhoneTextBox.ShortcutsEnabled = true;
            PhoneTextBox.Size = new Size(367, 48);
            PhoneTextBox.SkipLiterals = true;
            PhoneTextBox.TabIndex = 81;
            PhoneTextBox.TabStop = false;
            PhoneTextBox.Text = "   -   -";
            PhoneTextBox.TextAlign = HorizontalAlignment.Left;
            PhoneTextBox.TextMaskFormat = MaskFormat.IncludeLiterals;
            PhoneTextBox.TrailingIcon = null;
            PhoneTextBox.UseSystemPasswordChar = false;
            PhoneTextBox.ValidatingType = null;
            // 
            // EmailTextBox
            // 
            EmailTextBox.AnimateReadOnly = false;
            EmailTextBox.AutoCompleteMode = AutoCompleteMode.None;
            EmailTextBox.AutoCompleteSource = AutoCompleteSource.None;
            EmailTextBox.BackgroundImageLayout = ImageLayout.None;
            EmailTextBox.CharacterCasing = CharacterCasing.Normal;
            EmailTextBox.Cursor = Cursors.IBeam;
            EmailTextBox.Depth = 0;
            EmailTextBox.Font = new Font("Microsoft Sans Serif", 12F);
            EmailTextBox.HideSelection = true;
            EmailTextBox.Hint = "Email";
            EmailTextBox.LeadingIcon = null;
            EmailTextBox.Location = new Point(29, 163);
            EmailTextBox.Margin = new Padding(4, 3, 4, 3);
            EmailTextBox.MaxLength = 50;
            EmailTextBox.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.PasswordChar = '\0';
            EmailTextBox.PrefixSuffixText = null;
            EmailTextBox.ReadOnly = false;
            EmailTextBox.RightToLeft = RightToLeft.No;
            EmailTextBox.SelectedText = "";
            EmailTextBox.SelectionLength = 0;
            EmailTextBox.SelectionStart = 0;
            EmailTextBox.ShortcutsEnabled = true;
            EmailTextBox.Size = new Size(367, 48);
            EmailTextBox.TabIndex = 69;
            EmailTextBox.TabStop = false;
            EmailTextBox.TextAlign = HorizontalAlignment.Left;
            EmailTextBox.TrailingIcon = null;
            EmailTextBox.UseSystemPasswordChar = false;
            // 
            // materialLabel27
            // 
            materialLabel27.AutoSize = true;
            materialLabel27.Depth = 0;
            materialLabel27.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel27.FontType = Manager.MaterialSkinManager.FontType.H3;
            materialLabel27.Location = new Point(24, 20);
            materialLabel27.Margin = new Padding(4, 0, 4, 0);
            materialLabel27.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel27.Name = "materialLabel27";
            materialLabel27.Size = new Size(246, 58);
            materialLabel27.TabIndex = 62;
            materialLabel27.Text = "User profile";
            // 
            // materialLabel56
            // 
            materialLabel56.Depth = 0;
            materialLabel56.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel56.ForeColor = Color.FromArgb(180, 0, 0, 0);
            materialLabel56.Location = new Point(29, 94);
            materialLabel56.Margin = new Padding(4, 0, 4, 0);
            materialLabel56.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel56.Name = "materialLabel56";
            materialLabel56.Size = new Size(466, 43);
            materialLabel56.TabIndex = 61;
            materialLabel56.Text = "To save the changes made to the user data, click on the corresponding button";
            // 
            // SettingsPage
            // 
            SettingsPage.BackColor = Color.White;
            SettingsPage.Controls.Add(colorSchemeListView);
            SettingsPage.Controls.Add(materialLabel2);
            SettingsPage.Controls.Add(ChangeColorSchemeButton);
            SettingsPage.Controls.Add(CertificatePinningCheckBox);
            SettingsPage.Controls.Add(materialLabel28);
            SettingsPage.ImageKey = "settings_24dp_E8EAED_FILL0_wght300_GRAD0_opsz24.png";
            SettingsPage.Location = new Point(4, 31);
            SettingsPage.Margin = new Padding(4, 3, 4, 3);
            SettingsPage.Name = "SettingsPage";
            SettingsPage.Padding = new Padding(4, 3, 4, 3);
            SettingsPage.Size = new Size(1184, 648);
            SettingsPage.TabIndex = 3;
            SettingsPage.Text = "Settings";
            // 
            // colorSchemeListView
            // 
            colorSchemeListView.AllowColumnReorder = true;
            colorSchemeListView.AutoSizeTable = false;
            colorSchemeListView.BackColor = Color.FromArgb(255, 255, 255);
            colorSchemeListView.BorderStyle = BorderStyle.None;
            colorSchemeListView.Columns.AddRange(new ColumnHeader[] { ColorSchemeName });
            colorSchemeListView.Depth = 0;
            colorSchemeListView.Font = new Font("Microsoft Sans Serif", 34F, FontStyle.Bold, GraphicsUnit.Pixel);
            colorSchemeListView.FullRowSelect = true;
            colorSchemeListView.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            colorSchemeListView.Location = new Point(24, 140);
            colorSchemeListView.Margin = new Padding(4, 3, 4, 3);
            colorSchemeListView.MinimumSize = new Size(250, 200);
            colorSchemeListView.MouseLocation = new Point(-1, -1);
            colorSchemeListView.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            colorSchemeListView.MultiSelect = false;
            colorSchemeListView.Name = "colorSchemeListView";
            colorSchemeListView.OwnerDraw = true;
            colorSchemeListView.Size = new Size(471, 200);
            colorSchemeListView.TabIndex = 68;
            colorSchemeListView.UseCompatibleStateImageBehavior = false;
            colorSchemeListView.View = View.Details;
            // 
            // ColorSchemeName
            // 
            ColorSchemeName.Text = "Color scheme";
            ColorSchemeName.Width = 471;
            // 
            // materialLabel2
            // 
            materialLabel2.Depth = 0;
            materialLabel2.Font = new Font("Roboto", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialLabel2.ForeColor = Color.FromArgb(180, 0, 0, 0);
            materialLabel2.Location = new Point(29, 94);
            materialLabel2.Margin = new Padding(4, 0, 4, 0);
            materialLabel2.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel2.Name = "materialLabel2";
            materialLabel2.Size = new Size(466, 43);
            materialLabel2.TabIndex = 67;
            materialLabel2.Text = "In the settings panel, the appearance of the client application can be customised.";
            // 
            // ChangeColorSchemeButton
            // 
            ChangeColorSchemeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ChangeColorSchemeButton.CharacterCasing = MaterialButton.CharacterCasingEnum.Normal;
            ChangeColorSchemeButton.Density = MaterialButton.MaterialButtonDensity.Default;
            ChangeColorSchemeButton.Depth = 0;
            ChangeColorSchemeButton.HighEmphasis = true;
            ChangeColorSchemeButton.Icon = null;
            ChangeColorSchemeButton.IconType = MaterialButton.MaterialIconType.Rebase;
            ChangeColorSchemeButton.Location = new Point(24, 365);
            ChangeColorSchemeButton.Margin = new Padding(4, 6, 4, 6);
            ChangeColorSchemeButton.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            ChangeColorSchemeButton.Name = "ChangeColorSchemeButton";
            ChangeColorSchemeButton.NoAccentTextColor = Color.Empty;
            ChangeColorSchemeButton.Size = new Size(194, 36);
            ChangeColorSchemeButton.TabIndex = 66;
            ChangeColorSchemeButton.Text = "Change color scheme";
            ChangeColorSchemeButton.Type = MaterialButton.MaterialButtonType.Contained;
            ChangeColorSchemeButton.UseAccentColor = true;
            ChangeColorSchemeButton.UseVisualStyleBackColor = true;
            ChangeColorSchemeButton.Click += ChangeColorSchemeButton_Click;
            // 
            // CertificatePinningCheckBox
            // 
            CertificatePinningCheckBox.AutoSize = true;
            CertificatePinningCheckBox.Checked = true;
            CertificatePinningCheckBox.CheckState = CheckState.Checked;
            CertificatePinningCheckBox.Depth = 0;
            CertificatePinningCheckBox.Location = new Point(24, 422);
            CertificatePinningCheckBox.Margin = new Padding(0);
            CertificatePinningCheckBox.MouseLocation = new Point(-1, -1);
            CertificatePinningCheckBox.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            CertificatePinningCheckBox.Name = "CertificatePinningCheckBox";
            CertificatePinningCheckBox.ReadOnly = false;
            CertificatePinningCheckBox.Ripple = true;
            CertificatePinningCheckBox.Size = new Size(165, 37);
            CertificatePinningCheckBox.TabIndex = 65;
            CertificatePinningCheckBox.Text = "Certificate Pinning";
            CertificatePinningCheckBox.UseAccentColor = false;
            CertificatePinningCheckBox.UseVisualStyleBackColor = true;
            CertificatePinningCheckBox.Visible = false;
            CertificatePinningCheckBox.CheckedChanged += CertificatePinningCheckBox_CheckedChanged;
            // 
            // materialLabel28
            // 
            materialLabel28.AutoSize = true;
            materialLabel28.Depth = 0;
            materialLabel28.Font = new Font("Roboto", 48F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel28.FontType = Manager.MaterialSkinManager.FontType.H3;
            materialLabel28.Location = new Point(24, 20);
            materialLabel28.Margin = new Padding(4, 0, 4, 0);
            materialLabel28.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel28.Name = "materialLabel28";
            materialLabel28.Size = new Size(176, 58);
            materialLabel28.TabIndex = 63;
            materialLabel28.Text = "Settings";
            // 
            // menuIconList
            // 
            menuIconList.ColorDepth = ColorDepth.Depth32Bit;
            menuIconList.ImageStream = (ImageListStreamer)resources.GetObject("menuIconList.ImageStream");
            menuIconList.TransparentColor = Color.Transparent;
            menuIconList.Images.SetKeyName(0, "round_assessment_white_24dp.png");
            menuIconList.Images.SetKeyName(1, "round_backup_white_24dp.png");
            menuIconList.Images.SetKeyName(2, "round_bluetooth_white_24dp.png");
            menuIconList.Images.SetKeyName(3, "round_bookmark_white_24dp.png");
            menuIconList.Images.SetKeyName(4, "round_build_white_24dp.png");
            menuIconList.Images.SetKeyName(5, "round_gps_fixed_white_24dp.png");
            menuIconList.Images.SetKeyName(6, "round_http_white_24dp.png");
            menuIconList.Images.SetKeyName(7, "round_report_problem_white_24dp.png");
            menuIconList.Images.SetKeyName(8, "round_swap_vert_white_24dp.png");
            menuIconList.Images.SetKeyName(9, "round_phone_black_24dp.png");
            menuIconList.Images.SetKeyName(10, "round_push_pin_black_24dp.png");
            menuIconList.Images.SetKeyName(11, "round_mail_outline_black_24dp.png");
            menuIconList.Images.SetKeyName(12, "round_person_black_24dp.png");
            menuIconList.Images.SetKeyName(13, "round_add_a_photo_black_24dp.png");
            menuIconList.Images.SetKeyName(14, "round_alternate_email_black_24dp.png");
            menuIconList.Images.SetKeyName(15, "round_cancel_black_24dp.png");
            menuIconList.Images.SetKeyName(16, "round_error_black_24dp.png");
            menuIconList.Images.SetKeyName(17, "round_event_black_24dp.png");
            menuIconList.Images.SetKeyName(18, "local_shipping_24dp_E8EAED_FILL0_wght300_GRAD0_opsz24.png");
            menuIconList.Images.SetKeyName(19, "receipt_long_24dp_E8EAED_FILL0_wght300_GRAD0_opsz24.png");
            menuIconList.Images.SetKeyName(20, "calendar_month_24dp_E8EAED_FILL0_wght300_GRAD0_opsz24.png");
            menuIconList.Images.SetKeyName(21, "settings_24dp_E8EAED_FILL0_wght300_GRAD0_opsz24.png");
            menuIconList.Images.SetKeyName(22, "shopping_bag_24dp_E8EAED_FILL0_wght300_GRAD0_opsz24.png");
            menuIconList.Images.SetKeyName(23, "person_24dp_E8EAED_FILL0_wght300_GRAD0_opsz24.png");
            menuIconList.Images.SetKeyName(24, "shopping_cart_24dp_E8EAED_FILL0_wght300_GRAD0_opsz24.png");
            menuIconList.Images.SetKeyName(25, "calculate_24dp_E8EAED_FILL0_wght300_GRAD0_opsz24.png");
            menuIconList.Images.SetKeyName(26, "monitoring_24dp_E8EAED_FILL0_wght300_GRAD0_opsz24.png");
            // 
            // materialContextMenuStrip1
            // 
            materialContextMenuStrip1.BackColor = Color.FromArgb(255, 255, 255);
            materialContextMenuStrip1.Depth = 0;
            materialContextMenuStrip1.Font = new Font("Microsoft Sans Serif", 11F);
            materialContextMenuStrip1.ImageScalingSize = new Size(20, 20);
            materialContextMenuStrip1.Items.AddRange(new ToolStripItem[] { item1ToolStripMenuItem, disabledItemToolStripMenuItem, item2ToolStripMenuItem, toolStripSeparator1, item3ToolStripMenuItem });
            materialContextMenuStrip1.Margin = new Padding(16, 8, 16, 8);
            materialContextMenuStrip1.MouseState = Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialContextMenuStrip1.Name = "materialContextMenuStrip1";
            materialContextMenuStrip1.Size = new Size(166, 130);
            // 
            // item1ToolStripMenuItem
            // 
            item1ToolStripMenuItem.AutoSize = false;
            item1ToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { subItem1ToolStripMenuItem, subItem2ToolStripMenuItem });
            item1ToolStripMenuItem.Name = "item1ToolStripMenuItem";
            item1ToolStripMenuItem.Size = new Size(170, 30);
            item1ToolStripMenuItem.Text = "Item 1";
            // 
            // subItem1ToolStripMenuItem
            // 
            subItem1ToolStripMenuItem.AutoSize = false;
            subItem1ToolStripMenuItem.Name = "subItem1ToolStripMenuItem";
            subItem1ToolStripMenuItem.Size = new Size(152, 30);
            subItem1ToolStripMenuItem.Text = "SubItem 1";
            // 
            // subItem2ToolStripMenuItem
            // 
            subItem2ToolStripMenuItem.AutoSize = false;
            subItem2ToolStripMenuItem.Name = "subItem2ToolStripMenuItem";
            subItem2ToolStripMenuItem.Size = new Size(152, 30);
            subItem2ToolStripMenuItem.Text = "SubItem 2";
            // 
            // disabledItemToolStripMenuItem
            // 
            disabledItemToolStripMenuItem.AutoSize = false;
            disabledItemToolStripMenuItem.Enabled = false;
            disabledItemToolStripMenuItem.Name = "disabledItemToolStripMenuItem";
            disabledItemToolStripMenuItem.Size = new Size(170, 30);
            disabledItemToolStripMenuItem.Text = "Disabled item";
            // 
            // item2ToolStripMenuItem
            // 
            item2ToolStripMenuItem.AutoSize = false;
            item2ToolStripMenuItem.Name = "item2ToolStripMenuItem";
            item2ToolStripMenuItem.Size = new Size(170, 30);
            item2ToolStripMenuItem.Text = "Item 2";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(162, 6);
            // 
            // item3ToolStripMenuItem
            // 
            item3ToolStripMenuItem.AutoSize = false;
            item3ToolStripMenuItem.Name = "item3ToolStripMenuItem";
            item3ToolStripMenuItem.Size = new Size(170, 30);
            item3ToolStripMenuItem.Text = "Item 3";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 760);
            ContextMenuStrip = materialContextMenuStrip1;
            Controls.Add(materialTabControl1);
            DrawerShowIconsWhenHidden = true;
            DrawerTabControl = materialTabControl1;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MinimumSize = new Size(350, 231);
            Name = "MainForm";
            Padding = new Padding(4, 74, 4, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DVCA";
            FormClosed += MainForm_FormClosed;
            materialTabControl1.ResumeLayout(false);
            ShopPage.ResumeLayout(false);
            ShopPage.PerformLayout();
            BasketPage.ResumeLayout(false);
            BasketPage.PerformLayout();
            OrderPage.ResumeLayout(false);
            OrderPage.PerformLayout();
            BMIPage.ResumeLayout(false);
            BMIPage.PerformLayout();
            DiagramPage.ResumeLayout(false);
            DiagramPage.PerformLayout();
            ProfilePage.ResumeLayout(false);
            ProfilePage.PerformLayout();
            SettingsPage.ResumeLayout(false);
            SettingsPage.PerformLayout();
            materialContextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage ShopPage;
        private System.Windows.Forms.TabPage OrderPage;
        private System.Windows.Forms.TabPage ProfilePage;
        private MaterialContextMenuStrip materialContextMenuStrip1;
        private MaterialToolStripMenuItem item1ToolStripMenuItem;
        private MaterialToolStripMenuItem subItem1ToolStripMenuItem;
        private MaterialToolStripMenuItem subItem2ToolStripMenuItem;
        private MaterialToolStripMenuItem item2ToolStripMenuItem;
        private MaterialToolStripMenuItem item3ToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem disabledItemToolStripMenuItem;
        private System.Windows.Forms.TabPage SettingsPage;
        private System.Windows.Forms.TabPage DiagramPage;
        private ImageList menuIconList;
        private MaterialLabel materialLabel9;
        private MaterialButton RefreshDietsButton;
        private MaterialLabel materialLabel24;
        private MaterialLabel materialLabel27;
        private MaterialLabel materialLabel28;
        private MaterialLabel materialLabel29;
        private MaterialTextBoxEdit EmailTextBox;
        private MaterialLabel materialLabel56;
        private MaterialMaskedTextBox PhoneTextBox;
        private MaterialTextBoxEdit SurnameTextBox;
        private MaterialTextBoxEdit NameTextBox;
        private MaterialButton SaveChangesButton;
        private MaterialButton ChangePassButton;
        private MaterialTextBoxEdit NewPassAgainTextBox;
        private MaterialTextBoxEdit NewPassTextBox;
        private MaterialTextBoxEdit CurrentPassTextBox;
        private MaterialTextBoxEdit CityTextBox;
        private MaterialTextBoxEdit StreetNoTextBox;
        private MaterialTextBoxEdit StreetTextBox;
        private MaterialSwitch materialSwitch10;
        private MaterialMaskedTextBox PostalCodeTextBox;
        private System.Windows.Forms.TabPage BasketPage;
        private MaterialListView DietListView;
        private ColumnHeader NameHeader;
        private ColumnHeader PriceHeader;
        private ColumnHeader CaloriesHeader;
        private ColumnHeader IsVeganHeader;
        private ColumnHeader Id;
        private MaterialButton AddToCartButton;
        private MaterialLabel materialLabel1;
        private MaterialLabel materialLabel3;
        private MaterialLabel materialLabel6;
        private PoisonDateTime OrderFromDate;
        private MaterialListView BasketListView;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader8;
        private ColumnHeader columnHeader9;
        private MaterialLabel materialLabel8;
        private PoisonDateTime OrderToDate;
        private MaterialLabel materialLabel11;
        private MaterialRichTextBox DeliveryCommentTextBox;
        private MaterialLabel TotalOrderCostLabel;
        private MaterialLabel materialLabel12;
        private MaterialButton PlaceOrderButton;
        private MaterialButton materialButton3;
        private System.Windows.Forms.TabPage BMIPage;
        private MaterialLabel materialLabel7;
        private MaterialListView OrderListView;
        private ColumnHeader OrderIdHeader;
        private ColumnHeader StartDateHeader;
        private ColumnHeader EndDateHeader;
        private ColumnHeader OrderPriceHeader;
        private MaterialLabel materialLabel4;
        private MaterialLabel materialLabel5;
        private MaterialButton RefreshOrdersButton;
        private MaterialLabel materialLabel13;
        private MaterialListView DietInOrderListView;
        private ColumnHeader DietNameHeader;
        private MaterialLabel materialLabel10;
        private MaterialMaskedTextBox OrderDetailPostalTextBox;
        private MaterialTextBoxEdit OrderDetailCityTextBox;
        private MaterialTextBoxEdit OderDetailStreetNoTextBox;
        private MaterialTextBoxEdit OrderDetailStreetTextBox;
        private MaterialMaskedTextBox OrderDetailTelephoneTextBox;
        private MaterialLabel materialLabel14;
        private MaterialRichTextBox OrderDetailCommentTextBox;
        private MaterialButton LogoutButton;
        private MaterialLabel materialLabel15;
        private MaterialTextBoxEdit WeightTextBox;
        private MaterialTextBoxEdit AgeTextBox;
        private MaterialTextBoxEdit HeightTextBox;
        private MaterialLabel materialLabel16;
        private MaterialButton CalculateBMRButton;
        private MaterialRadioButton FemaleRadioButton;
        private MaterialRadioButton MaleRadioButton;
        private MaterialLabel BMRResultLabel;
        private MaterialLabel materialLabel17;
        private MaterialLabel BMIResultLabel;
        private MaterialLabel materialLabel19;
        private MaterialButton CalculateBMIButton;
        private MaterialTextBoxEdit BMIWeightTextBox;
        private MaterialTextBoxEdit BMIHeightTextBox;
        private MaterialLabel materialLabel18;
        private MaterialLabel materialLabel26;
        private MaterialLabel materialLabel30;
        private MaterialLabel materialLabel31;
        private MaterialLabel materialLabel32;
        private MaterialLabel materialLabel23;
        private MaterialLabel materialLabel25;
        private MaterialLabel materialLabel22;
        private MaterialLabel materialLabel21;
        private MaterialLabel materialLabel20;
        private MaterialListView DiagramItemsListView;
        private ColumnHeader DateHeader;
        private ColumnHeader WeightHeader;
        private PoisonDateTime AddDiagramDate;
        private MaterialTextBoxEdit AddDiagramWeigth;
        private MaterialButton AddDiagramButton;
        private MaterialButton RemoveFromWeightDiagramButton;
        private ScottPlot.WinForms.FormsPlot WeightPlot;
        private MaterialButton ExportOrderToPDFButton;
        private MaterialCheckBox CertificatePinningCheckBox;
        private MaterialButton ChangeColorSchemeButton;
        private MaterialLabel materialLabel2;
        private MaterialListView colorSchemeListView;
        private ColumnHeader ColorSchemeName;
        private MaterialLabel materialLabel33;
    }
}