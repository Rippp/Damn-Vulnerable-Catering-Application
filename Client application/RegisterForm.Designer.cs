namespace DamnVulnerableCateringApplication
{
    partial class RegisterForm
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
            nightForm1 = new ReaLTaiizor.Forms.NightForm();
            EmailErrorLabel = new ReaLTaiizor.Controls.MaterialLabel();
            RegisterButton = new ReaLTaiizor.Controls.MaterialButton();
            parrotGroupBox3 = new ReaLTaiizor.Controls.ParrotGroupBox();
            PasswordErrorLabel = new ReaLTaiizor.Controls.MaterialLabel();
            dungeonLabel3 = new ReaLTaiizor.Controls.DungeonLabel();
            dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            PasswordBox = new ReaLTaiizor.Controls.HopeTextBox();
            RepeatPasswordBox = new ReaLTaiizor.Controls.HopeTextBox();
            parrotGroupBox2 = new ReaLTaiizor.Controls.ParrotGroupBox();
            PostalCodeBox = new ReaLTaiizor.Controls.HopeTextBox();
            StreetBox = new ReaLTaiizor.Controls.HopeTextBox();
            CityBox = new ReaLTaiizor.Controls.HopeTextBox();
            BuildingNumberBox = new ReaLTaiizor.Controls.HopeTextBox();
            parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            TelephoneBox = new ReaLTaiizor.Controls.HopeTextBox();
            EmailBox = new ReaLTaiizor.Controls.HopeTextBox();
            SurnameBox = new ReaLTaiizor.Controls.HopeTextBox();
            NameBox = new ReaLTaiizor.Controls.HopeTextBox();
            dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            BackToLoginButton = new ReaLTaiizor.Controls.MaterialButton();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            nightForm1.SuspendLayout();
            parrotGroupBox3.SuspendLayout();
            parrotGroupBox2.SuspendLayout();
            parrotGroupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // nightForm1
            // 
            nightForm1.BackColor = Color.FromArgb(4, 12, 45);
            nightForm1.Controls.Add(EmailErrorLabel);
            nightForm1.Controls.Add(RegisterButton);
            nightForm1.Controls.Add(parrotGroupBox3);
            nightForm1.Controls.Add(parrotGroupBox2);
            nightForm1.Controls.Add(parrotGroupBox1);
            nightForm1.Controls.Add(dungeonLabel1);
            nightForm1.Controls.Add(BackToLoginButton);
            nightForm1.Controls.Add(nightControlBox1);
            nightForm1.Dock = DockStyle.Fill;
            nightForm1.DrawIcon = false;
            nightForm1.Font = new Font("Segoe UI", 9F);
            nightForm1.HeadColor = Color.MidnightBlue;
            nightForm1.Location = new Point(0, 0);
            nightForm1.MinimumSize = new Size(100, 42);
            nightForm1.Name = "nightForm1";
            nightForm1.Padding = new Padding(0, 31, 0, 0);
            nightForm1.Size = new Size(706, 503);
            nightForm1.TabIndex = 1;
            nightForm1.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            nightForm1.TitleBarTextColor = Color.Gainsboro;
            // 
            // EmailErrorLabel
            // 
            EmailErrorLabel.Cursor = Cursors.Hand;
            EmailErrorLabel.Depth = 0;
            EmailErrorLabel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            EmailErrorLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            EmailErrorLabel.HighEmphasis = true;
            EmailErrorLabel.Location = new Point(360, 384);
            EmailErrorLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            EmailErrorLabel.Name = "EmailErrorLabel";
            EmailErrorLabel.Size = new Size(185, 39);
            EmailErrorLabel.TabIndex = 29;
            EmailErrorLabel.Text = "Given e-mail address is already registered";
            EmailErrorLabel.UseAccent = true;
            EmailErrorLabel.Visible = false;
            // 
            // RegisterButton
            // 
            RegisterButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RegisterButton.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            RegisterButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            RegisterButton.Depth = 0;
            RegisterButton.HighEmphasis = true;
            RegisterButton.Icon = null;
            RegisterButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            RegisterButton.Location = new Point(360, 429);
            RegisterButton.Margin = new Padding(4, 6, 4, 6);
            RegisterButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            RegisterButton.Name = "RegisterButton";
            RegisterButton.NoAccentTextColor = Color.Empty;
            RegisterButton.Size = new Size(89, 36);
            RegisterButton.TabIndex = 25;
            RegisterButton.Text = "Register";
            RegisterButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            RegisterButton.UseAccentColor = true;
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // parrotGroupBox3
            // 
            parrotGroupBox3.BorderColor = Color.FromArgb(255, 64, 129);
            parrotGroupBox3.BorderWidth = 1;
            parrotGroupBox3.Controls.Add(PasswordErrorLabel);
            parrotGroupBox3.Controls.Add(dungeonLabel3);
            parrotGroupBox3.Controls.Add(dungeonLabel2);
            parrotGroupBox3.Controls.Add(PasswordBox);
            parrotGroupBox3.Controls.Add(RepeatPasswordBox);
            parrotGroupBox3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotGroupBox3.Location = new Point(31, 286);
            parrotGroupBox3.Name = "parrotGroupBox3";
            parrotGroupBox3.ShowText = true;
            parrotGroupBox3.Size = new Size(311, 179);
            parrotGroupBox3.TabIndex = 24;
            parrotGroupBox3.TabStop = false;
            parrotGroupBox3.Text = "Credentials";
            parrotGroupBox3.TextColor = Color.FromArgb(255, 64, 129);
            // 
            // PasswordErrorLabel
            // 
            PasswordErrorLabel.AutoSize = true;
            PasswordErrorLabel.Cursor = Cursors.Hand;
            PasswordErrorLabel.Depth = 0;
            PasswordErrorLabel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            PasswordErrorLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            PasswordErrorLabel.HighEmphasis = true;
            PasswordErrorLabel.Location = new Point(8, 155);
            PasswordErrorLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            PasswordErrorLabel.Name = "PasswordErrorLabel";
            PasswordErrorLabel.Size = new Size(177, 17);
            PasswordErrorLabel.TabIndex = 26;
            PasswordErrorLabel.Text = "Passwords are not identical";
            PasswordErrorLabel.UseAccent = true;
            PasswordErrorLabel.Visible = false;
            // 
            // dungeonLabel3
            // 
            dungeonLabel3.AutoSize = true;
            dungeonLabel3.BackColor = Color.Transparent;
            dungeonLabel3.Font = new Font("Segoe UI", 11F);
            dungeonLabel3.ForeColor = SystemColors.ButtonShadow;
            dungeonLabel3.Location = new Point(6, 91);
            dungeonLabel3.Name = "dungeonLabel3";
            dungeonLabel3.Size = new Size(133, 20);
            dungeonLabel3.TabIndex = 28;
            dungeonLabel3.Text = "Re-enter password";
            // 
            // dungeonLabel2
            // 
            dungeonLabel2.AutoSize = true;
            dungeonLabel2.BackColor = Color.Transparent;
            dungeonLabel2.Font = new Font("Segoe UI", 11F);
            dungeonLabel2.ForeColor = SystemColors.ButtonShadow;
            dungeonLabel2.Location = new Point(6, 23);
            dungeonLabel2.Name = "dungeonLabel2";
            dungeonLabel2.Size = new Size(70, 20);
            dungeonLabel2.TabIndex = 27;
            dungeonLabel2.Text = "Password";
            // 
            // PasswordBox
            // 
            PasswordBox.BackColor = Color.FromArgb(4, 12, 45);
            PasswordBox.BaseColor = Color.Transparent;
            PasswordBox.BorderColorA = Color.DodgerBlue;
            PasswordBox.BorderColorB = Color.DarkGray;
            PasswordBox.Font = new Font("Segoe UI", 12F);
            PasswordBox.ForeColor = Color.Gainsboro;
            PasswordBox.Hint = "";
            PasswordBox.Location = new Point(8, 46);
            PasswordBox.MaxLength = 128;
            PasswordBox.Multiline = false;
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '\0';
            PasswordBox.ScrollBars = ScrollBars.None;
            PasswordBox.SelectedText = "";
            PasswordBox.SelectionLength = 0;
            PasswordBox.SelectionStart = 0;
            PasswordBox.Size = new Size(284, 38);
            PasswordBox.TabIndex = 19;
            PasswordBox.TabStop = false;
            PasswordBox.Text = "Password";
            PasswordBox.UseSystemPasswordChar = true;
            // 
            // RepeatPasswordBox
            // 
            RepeatPasswordBox.BackColor = Color.FromArgb(4, 12, 45);
            RepeatPasswordBox.BaseColor = Color.Transparent;
            RepeatPasswordBox.BorderColorA = Color.DodgerBlue;
            RepeatPasswordBox.BorderColorB = Color.DarkGray;
            RepeatPasswordBox.Font = new Font("Segoe UI", 12F);
            RepeatPasswordBox.ForeColor = Color.Gainsboro;
            RepeatPasswordBox.Hint = "";
            RepeatPasswordBox.Location = new Point(8, 114);
            RepeatPasswordBox.MaxLength = 128;
            RepeatPasswordBox.Multiline = false;
            RepeatPasswordBox.Name = "RepeatPasswordBox";
            RepeatPasswordBox.PasswordChar = '\0';
            RepeatPasswordBox.ScrollBars = ScrollBars.None;
            RepeatPasswordBox.SelectedText = "";
            RepeatPasswordBox.SelectionLength = 0;
            RepeatPasswordBox.SelectionStart = 0;
            RepeatPasswordBox.Size = new Size(284, 38);
            RepeatPasswordBox.TabIndex = 20;
            RepeatPasswordBox.TabStop = false;
            RepeatPasswordBox.Text = "Password";
            RepeatPasswordBox.UseSystemPasswordChar = true;
            // 
            // parrotGroupBox2
            // 
            parrotGroupBox2.BorderColor = Color.FromArgb(255, 64, 129);
            parrotGroupBox2.BorderWidth = 1;
            parrotGroupBox2.Controls.Add(PostalCodeBox);
            parrotGroupBox2.Controls.Add(StreetBox);
            parrotGroupBox2.Controls.Add(CityBox);
            parrotGroupBox2.Controls.Add(BuildingNumberBox);
            parrotGroupBox2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotGroupBox2.Location = new Point(360, 71);
            parrotGroupBox2.Name = "parrotGroupBox2";
            parrotGroupBox2.ShowText = true;
            parrotGroupBox2.Size = new Size(311, 209);
            parrotGroupBox2.TabIndex = 24;
            parrotGroupBox2.TabStop = false;
            parrotGroupBox2.Text = "Address details";
            parrotGroupBox2.TextColor = Color.FromArgb(255, 64, 129);
            // 
            // PostalCodeBox
            // 
            PostalCodeBox.BackColor = Color.FromArgb(4, 12, 45);
            PostalCodeBox.BaseColor = Color.Transparent;
            PostalCodeBox.BorderColorA = Color.DodgerBlue;
            PostalCodeBox.BorderColorB = Color.DarkGray;
            PostalCodeBox.Font = new Font("Segoe UI", 12F);
            PostalCodeBox.ForeColor = Color.Gainsboro;
            PostalCodeBox.Hint = "";
            PostalCodeBox.Location = new Point(6, 114);
            PostalCodeBox.MaxLength = 128;
            PostalCodeBox.Multiline = false;
            PostalCodeBox.Name = "PostalCodeBox";
            PostalCodeBox.PasswordChar = '\0';
            PostalCodeBox.ScrollBars = ScrollBars.None;
            PostalCodeBox.SelectedText = "";
            PostalCodeBox.SelectionLength = 0;
            PostalCodeBox.SelectionStart = 0;
            PostalCodeBox.Size = new Size(284, 38);
            PostalCodeBox.TabIndex = 22;
            PostalCodeBox.TabStop = false;
            PostalCodeBox.Text = "Postal code";
            PostalCodeBox.UseSystemPasswordChar = false;
            // 
            // StreetBox
            // 
            StreetBox.BackColor = Color.FromArgb(4, 12, 45);
            StreetBox.BaseColor = Color.Transparent;
            StreetBox.BorderColorA = Color.DodgerBlue;
            StreetBox.BorderColorB = Color.DarkGray;
            StreetBox.Font = new Font("Segoe UI", 12F);
            StreetBox.ForeColor = Color.Gainsboro;
            StreetBox.Hint = "";
            StreetBox.Location = new Point(6, 26);
            StreetBox.MaxLength = 128;
            StreetBox.Multiline = false;
            StreetBox.Name = "StreetBox";
            StreetBox.PasswordChar = '\0';
            StreetBox.ScrollBars = ScrollBars.None;
            StreetBox.SelectedText = "";
            StreetBox.SelectionLength = 0;
            StreetBox.SelectionStart = 0;
            StreetBox.Size = new Size(284, 38);
            StreetBox.TabIndex = 19;
            StreetBox.TabStop = false;
            StreetBox.Text = "Street";
            StreetBox.UseSystemPasswordChar = false;
            // 
            // CityBox
            // 
            CityBox.BackColor = Color.FromArgb(4, 12, 45);
            CityBox.BaseColor = Color.Transparent;
            CityBox.BorderColorA = Color.DodgerBlue;
            CityBox.BorderColorB = Color.DarkGray;
            CityBox.Font = new Font("Segoe UI", 12F);
            CityBox.ForeColor = Color.Gainsboro;
            CityBox.Hint = "";
            CityBox.Location = new Point(6, 158);
            CityBox.MaxLength = 128;
            CityBox.Multiline = false;
            CityBox.Name = "CityBox";
            CityBox.PasswordChar = '\0';
            CityBox.ScrollBars = ScrollBars.None;
            CityBox.SelectedText = "";
            CityBox.SelectionLength = 0;
            CityBox.SelectionStart = 0;
            CityBox.Size = new Size(284, 38);
            CityBox.TabIndex = 21;
            CityBox.TabStop = false;
            CityBox.Text = "City";
            CityBox.UseSystemPasswordChar = false;
            // 
            // BuildingNumberBox
            // 
            BuildingNumberBox.BackColor = Color.FromArgb(4, 12, 45);
            BuildingNumberBox.BaseColor = Color.Transparent;
            BuildingNumberBox.BorderColorA = Color.DodgerBlue;
            BuildingNumberBox.BorderColorB = Color.DarkGray;
            BuildingNumberBox.Font = new Font("Segoe UI", 12F);
            BuildingNumberBox.ForeColor = Color.Gainsboro;
            BuildingNumberBox.Hint = "";
            BuildingNumberBox.Location = new Point(6, 70);
            BuildingNumberBox.MaxLength = 128;
            BuildingNumberBox.Multiline = false;
            BuildingNumberBox.Name = "BuildingNumberBox";
            BuildingNumberBox.PasswordChar = '\0';
            BuildingNumberBox.ScrollBars = ScrollBars.None;
            BuildingNumberBox.SelectedText = "";
            BuildingNumberBox.SelectionLength = 0;
            BuildingNumberBox.SelectionStart = 0;
            BuildingNumberBox.Size = new Size(284, 38);
            BuildingNumberBox.TabIndex = 20;
            BuildingNumberBox.TabStop = false;
            BuildingNumberBox.Text = "Street No.";
            BuildingNumberBox.UseSystemPasswordChar = false;
            // 
            // parrotGroupBox1
            // 
            parrotGroupBox1.BorderColor = Color.FromArgb(255, 64, 129);
            parrotGroupBox1.BorderWidth = 1;
            parrotGroupBox1.Controls.Add(TelephoneBox);
            parrotGroupBox1.Controls.Add(EmailBox);
            parrotGroupBox1.Controls.Add(SurnameBox);
            parrotGroupBox1.Controls.Add(NameBox);
            parrotGroupBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            parrotGroupBox1.Location = new Point(31, 71);
            parrotGroupBox1.Name = "parrotGroupBox1";
            parrotGroupBox1.ShowText = true;
            parrotGroupBox1.Size = new Size(312, 209);
            parrotGroupBox1.TabIndex = 23;
            parrotGroupBox1.TabStop = false;
            parrotGroupBox1.Text = "Contact details";
            parrotGroupBox1.TextColor = Color.FromArgb(255, 64, 129);
            // 
            // TelephoneBox
            // 
            TelephoneBox.BackColor = Color.FromArgb(4, 12, 45);
            TelephoneBox.BaseColor = Color.Transparent;
            TelephoneBox.BorderColorA = Color.DodgerBlue;
            TelephoneBox.BorderColorB = Color.DarkGray;
            TelephoneBox.Font = new Font("Segoe UI", 12F);
            TelephoneBox.ForeColor = Color.Gainsboro;
            TelephoneBox.Hint = "";
            TelephoneBox.Location = new Point(6, 158);
            TelephoneBox.MaxLength = 128;
            TelephoneBox.Multiline = false;
            TelephoneBox.Name = "TelephoneBox";
            TelephoneBox.PasswordChar = '\0';
            TelephoneBox.ScrollBars = ScrollBars.None;
            TelephoneBox.SelectedText = "";
            TelephoneBox.SelectionLength = 0;
            TelephoneBox.SelectionStart = 0;
            TelephoneBox.Size = new Size(286, 38);
            TelephoneBox.TabIndex = 22;
            TelephoneBox.TabStop = false;
            TelephoneBox.Text = "Phone number";
            TelephoneBox.UseSystemPasswordChar = false;
            // 
            // EmailBox
            // 
            EmailBox.BackColor = Color.FromArgb(4, 12, 45);
            EmailBox.BaseColor = Color.Transparent;
            EmailBox.BorderColorA = Color.DodgerBlue;
            EmailBox.BorderColorB = Color.DarkGray;
            EmailBox.Font = new Font("Segoe UI", 12F);
            EmailBox.ForeColor = Color.Gainsboro;
            EmailBox.Hint = "";
            EmailBox.Location = new Point(6, 26);
            EmailBox.MaxLength = 128;
            EmailBox.Multiline = false;
            EmailBox.Name = "EmailBox";
            EmailBox.PasswordChar = '\0';
            EmailBox.ScrollBars = ScrollBars.None;
            EmailBox.SelectedText = "";
            EmailBox.SelectionLength = 0;
            EmailBox.SelectionStart = 0;
            EmailBox.Size = new Size(286, 38);
            EmailBox.TabIndex = 19;
            EmailBox.TabStop = false;
            EmailBox.Text = "Email";
            EmailBox.UseSystemPasswordChar = false;
            // 
            // SurnameBox
            // 
            SurnameBox.BackColor = Color.FromArgb(4, 12, 45);
            SurnameBox.BaseColor = Color.Transparent;
            SurnameBox.BorderColorA = Color.DodgerBlue;
            SurnameBox.BorderColorB = Color.DarkGray;
            SurnameBox.Font = new Font("Segoe UI", 12F);
            SurnameBox.ForeColor = Color.Gainsboro;
            SurnameBox.Hint = "";
            SurnameBox.Location = new Point(6, 114);
            SurnameBox.MaxLength = 128;
            SurnameBox.Multiline = false;
            SurnameBox.Name = "SurnameBox";
            SurnameBox.PasswordChar = '\0';
            SurnameBox.ScrollBars = ScrollBars.None;
            SurnameBox.SelectedText = "";
            SurnameBox.SelectionLength = 0;
            SurnameBox.SelectionStart = 0;
            SurnameBox.Size = new Size(286, 38);
            SurnameBox.TabIndex = 21;
            SurnameBox.TabStop = false;
            SurnameBox.Text = "Surname";
            SurnameBox.UseSystemPasswordChar = false;
            // 
            // NameBox
            // 
            NameBox.BackColor = Color.FromArgb(4, 12, 45);
            NameBox.BaseColor = Color.Transparent;
            NameBox.BorderColorA = Color.DodgerBlue;
            NameBox.BorderColorB = Color.DarkGray;
            NameBox.Font = new Font("Segoe UI", 12F);
            NameBox.ForeColor = Color.Gainsboro;
            NameBox.Hint = "";
            NameBox.Location = new Point(6, 70);
            NameBox.MaxLength = 128;
            NameBox.Multiline = false;
            NameBox.Name = "NameBox";
            NameBox.PasswordChar = '\0';
            NameBox.ScrollBars = ScrollBars.None;
            NameBox.SelectedText = "";
            NameBox.SelectionLength = 0;
            NameBox.SelectionStart = 0;
            NameBox.Size = new Size(286, 38);
            NameBox.TabIndex = 20;
            NameBox.TabStop = false;
            NameBox.Text = "Name";
            NameBox.UseSystemPasswordChar = false;
            // 
            // dungeonLabel1
            // 
            dungeonLabel1.BackColor = Color.Transparent;
            dungeonLabel1.Font = new Font("Segoe UI", 11F);
            dungeonLabel1.ForeColor = SystemColors.ButtonShadow;
            dungeonLabel1.Location = new Point(562, 377);
            dungeonLabel1.Name = "dungeonLabel1";
            dungeonLabel1.Size = new Size(144, 46);
            dungeonLabel1.TabIndex = 18;
            dungeonLabel1.Text = "Already have an account?";
            // 
            // BackToLoginButton
            // 
            BackToLoginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackToLoginButton.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            BackToLoginButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            BackToLoginButton.Depth = 0;
            BackToLoginButton.HighEmphasis = true;
            BackToLoginButton.Icon = null;
            BackToLoginButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            BackToLoginButton.Location = new Point(565, 429);
            BackToLoginButton.Margin = new Padding(4, 6, 4, 6);
            BackToLoginButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            BackToLoginButton.Name = "BackToLoginButton";
            BackToLoginButton.NoAccentTextColor = Color.Empty;
            BackToLoginButton.Size = new Size(106, 36);
            BackToLoginButton.TabIndex = 1;
            BackToLoginButton.Text = "Login";
            BackToLoginButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            BackToLoginButton.UseAccentColor = false;
            BackToLoginButton.UseVisualStyleBackColor = true;
            BackToLoginButton.Click += BackToLoginButton_Click;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(567, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 0;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 503);
            Controls.Add(nightForm1);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1032);
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            TransparencyKey = Color.Fuchsia;
            FormClosed += RegisterForm_FormClosed;
            nightForm1.ResumeLayout(false);
            nightForm1.PerformLayout();
            parrotGroupBox3.ResumeLayout(false);
            parrotGroupBox3.PerformLayout();
            parrotGroupBox2.ResumeLayout(false);
            parrotGroupBox2.PerformLayout();
            parrotGroupBox1.ResumeLayout(false);
            parrotGroupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Forms.NightForm nightForm1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.MaterialButton BackToLoginButton;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.HopeTextBox TelephoneBox;
        private ReaLTaiizor.Controls.HopeTextBox SurnameBox;
        private ReaLTaiizor.Controls.HopeTextBox NameBox;
        private ReaLTaiizor.Controls.HopeTextBox EmailBox;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox2;
        private ReaLTaiizor.Controls.HopeTextBox PostalCodeBox;
        private ReaLTaiizor.Controls.HopeTextBox StreetBox;
        private ReaLTaiizor.Controls.HopeTextBox CityBox;
        private ReaLTaiizor.Controls.HopeTextBox BuildingNumberBox;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox3;
        private ReaLTaiizor.Controls.HopeTextBox PasswordBox;
        private ReaLTaiizor.Controls.HopeTextBox RepeatPasswordBox;
        private ReaLTaiizor.Controls.MaterialButton RegisterButton;
        private ReaLTaiizor.Controls.MaterialLabel PasswordErrorLabel;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel3;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private ReaLTaiizor.Controls.MaterialLabel EmailErrorLabel;
    }
}