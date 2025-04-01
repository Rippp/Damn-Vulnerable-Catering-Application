

namespace DamnVulnerableCateringApplication
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            EmailLoginTextBox = new ReaLTaiizor.Controls.HopeTextBox();
            PasswordLoginTextBox = new ReaLTaiizor.Controls.HopeTextBox();
            DVCAForm = new ReaLTaiizor.Forms.NightForm();
            GoOfflineModeButton = new ReaLTaiizor.Controls.MaterialButton();
            IncorrectCredentialsLabel = new ReaLTaiizor.Controls.MaterialLabel();
            dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            materialLabel1 = new ReaLTaiizor.Controls.MaterialLabel();
            LoginRememberMeSwitch = new ReaLTaiizor.Controls.HopeSwitch();
            RegisterButton = new ReaLTaiizor.Controls.MaterialButton();
            LoginButton = new ReaLTaiizor.Controls.MaterialButton();
            DVCAForm.SuspendLayout();
            SuspendLayout();
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
            nightControlBox1.Location = new Point(661, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 4;
            // 
            // EmailLoginTextBox
            // 
            EmailLoginTextBox.BackColor = Color.FromArgb(4, 12, 45);
            EmailLoginTextBox.BaseColor = Color.Transparent;
            EmailLoginTextBox.BorderColorA = Color.DodgerBlue;
            EmailLoginTextBox.BorderColorB = Color.DarkGray;
            EmailLoginTextBox.Font = new Font("Segoe UI", 12F);
            EmailLoginTextBox.ForeColor = Color.Gainsboro;
            EmailLoginTextBox.Hint = "Email";
            EmailLoginTextBox.Location = new Point(49, 114);
            EmailLoginTextBox.MaxLength = 128;
            EmailLoginTextBox.Multiline = false;
            EmailLoginTextBox.Name = "EmailLoginTextBox";
            EmailLoginTextBox.PasswordChar = '\0';
            EmailLoginTextBox.ScrollBars = ScrollBars.None;
            EmailLoginTextBox.SelectedText = "";
            EmailLoginTextBox.SelectionLength = 0;
            EmailLoginTextBox.SelectionStart = 0;
            EmailLoginTextBox.Size = new Size(235, 38);
            EmailLoginTextBox.TabIndex = 11;
            EmailLoginTextBox.TabStop = false;
            EmailLoginTextBox.UseSystemPasswordChar = false;
            // 
            // PasswordLoginTextBox
            // 
            PasswordLoginTextBox.BackColor = Color.FromArgb(4, 12, 45);
            PasswordLoginTextBox.BaseColor = Color.Transparent;
            PasswordLoginTextBox.BorderColorA = Color.DodgerBlue;
            PasswordLoginTextBox.BorderColorB = Color.DarkGray;
            PasswordLoginTextBox.Font = new Font("Segoe UI", 12F);
            PasswordLoginTextBox.ForeColor = Color.Gainsboro;
            PasswordLoginTextBox.Hint = "Password";
            PasswordLoginTextBox.Location = new Point(49, 170);
            PasswordLoginTextBox.MaxLength = 128;
            PasswordLoginTextBox.Multiline = false;
            PasswordLoginTextBox.Name = "PasswordLoginTextBox";
            PasswordLoginTextBox.PasswordChar = '\0';
            PasswordLoginTextBox.ScrollBars = ScrollBars.None;
            PasswordLoginTextBox.SelectedText = "";
            PasswordLoginTextBox.SelectionLength = 0;
            PasswordLoginTextBox.SelectionStart = 0;
            PasswordLoginTextBox.Size = new Size(235, 38);
            PasswordLoginTextBox.TabIndex = 12;
            PasswordLoginTextBox.TabStop = false;
            PasswordLoginTextBox.UseSystemPasswordChar = true;
            // 
            // DVCAForm
            // 
            DVCAForm.BackColor = Color.FromArgb(4, 12, 45);
            DVCAForm.Controls.Add(GoOfflineModeButton);
            DVCAForm.Controls.Add(IncorrectCredentialsLabel);
            DVCAForm.Controls.Add(dungeonLabel1);
            DVCAForm.Controls.Add(materialLabel1);
            DVCAForm.Controls.Add(LoginRememberMeSwitch);
            DVCAForm.Controls.Add(RegisterButton);
            DVCAForm.Controls.Add(LoginButton);
            DVCAForm.Controls.Add(PasswordLoginTextBox);
            DVCAForm.Controls.Add(EmailLoginTextBox);
            DVCAForm.Controls.Add(nightControlBox1);
            DVCAForm.Dock = DockStyle.Fill;
            DVCAForm.DrawIcon = false;
            DVCAForm.Font = new Font("Segoe UI", 9F);
            DVCAForm.HeadColor = Color.MidnightBlue;
            DVCAForm.Location = new Point(0, 0);
            DVCAForm.MinimumSize = new Size(100, 42);
            DVCAForm.Name = "DVCAForm";
            DVCAForm.Padding = new Padding(0, 31, 0, 0);
            DVCAForm.Size = new Size(800, 450);
            DVCAForm.TabIndex = 2;
            DVCAForm.TextAlignment = ReaLTaiizor.Forms.NightForm.Alignment.Left;
            DVCAForm.TitleBarTextColor = Color.Gainsboro;
            // 
            // GoOfflineModeButton
            // 
            GoOfflineModeButton.AutoSize = false;
            GoOfflineModeButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            GoOfflineModeButton.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            GoOfflineModeButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            GoOfflineModeButton.Depth = 0;
            GoOfflineModeButton.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            GoOfflineModeButton.HighEmphasis = true;
            GoOfflineModeButton.Icon = null;
            GoOfflineModeButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            GoOfflineModeButton.Location = new Point(306, 361);
            GoOfflineModeButton.Margin = new Padding(4, 6, 4, 6);
            GoOfflineModeButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            GoOfflineModeButton.Name = "GoOfflineModeButton";
            GoOfflineModeButton.NoAccentTextColor = Color.Empty;
            GoOfflineModeButton.Size = new Size(235, 36);
            GoOfflineModeButton.TabIndex = 19;
            GoOfflineModeButton.Text = "Go to offline mode";
            GoOfflineModeButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            GoOfflineModeButton.UseAccentColor = false;
            GoOfflineModeButton.UseVisualStyleBackColor = true;
            GoOfflineModeButton.Click += GoOfflineModeButton_Click;
            // 
            // IncorrectCredentialsLabel
            // 
            IncorrectCredentialsLabel.AutoSize = true;
            IncorrectCredentialsLabel.Cursor = Cursors.Hand;
            IncorrectCredentialsLabel.Depth = 0;
            IncorrectCredentialsLabel.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            IncorrectCredentialsLabel.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            IncorrectCredentialsLabel.HighEmphasis = true;
            IncorrectCredentialsLabel.Location = new Point(49, 94);
            IncorrectCredentialsLabel.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            IncorrectCredentialsLabel.Name = "IncorrectCredentialsLabel";
            IncorrectCredentialsLabel.Size = new Size(168, 17);
            IncorrectCredentialsLabel.TabIndex = 18;
            IncorrectCredentialsLabel.Text = "Incorrect login credentials";
            IncorrectCredentialsLabel.UseAccent = true;
            IncorrectCredentialsLabel.Visible = false;
            // 
            // dungeonLabel1
            // 
            dungeonLabel1.AutoSize = true;
            dungeonLabel1.BackColor = Color.Transparent;
            dungeonLabel1.Font = new Font("Segoe UI", 11F);
            dungeonLabel1.ForeColor = SystemColors.ButtonShadow;
            dungeonLabel1.Location = new Point(49, 335);
            dungeonLabel1.Name = "dungeonLabel1";
            dungeonLabel1.Size = new Size(187, 20);
            dungeonLabel1.TabIndex = 17;
            dungeonLabel1.Text = "Don't have an account yet?";
            // 
            // materialLabel1
            // 
            materialLabel1.AutoSize = true;
            materialLabel1.Cursor = Cursors.Hand;
            materialLabel1.Depth = 0;
            materialLabel1.Font = new Font("Roboto Medium", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            materialLabel1.FontType = ReaLTaiizor.Manager.MaterialSkinManager.FontType.Subtitle2;
            materialLabel1.HighEmphasis = true;
            materialLabel1.Location = new Point(98, 222);
            materialLabel1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialLabel1.Name = "materialLabel1";
            materialLabel1.Size = new Size(94, 17);
            materialLabel1.TabIndex = 16;
            materialLabel1.Text = "Remember me";
            materialLabel1.UseAccent = true;
            materialLabel1.Click += materialLabel1_Click;
            // 
            // LoginRememberMeSwitch
            // 
            LoginRememberMeSwitch.AutoSize = true;
            LoginRememberMeSwitch.BaseColor = Color.FromArgb(4, 12, 45);
            LoginRememberMeSwitch.BaseOffColor = Color.FromArgb(221, 141, 144);
            LoginRememberMeSwitch.BaseOnColor = Color.FromArgb(255, 128, 128);
            LoginRememberMeSwitch.Checked = true;
            LoginRememberMeSwitch.CheckState = CheckState.Checked;
            LoginRememberMeSwitch.Location = new Point(49, 221);
            LoginRememberMeSwitch.Name = "LoginRememberMeSwitch";
            LoginRememberMeSwitch.Size = new Size(40, 20);
            LoginRememberMeSwitch.TabIndex = 15;
            LoginRememberMeSwitch.Text = "hopeSwitch1";
            LoginRememberMeSwitch.UseVisualStyleBackColor = true;
            // 
            // RegisterButton
            // 
            RegisterButton.AutoSize = false;
            RegisterButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            RegisterButton.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            RegisterButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            RegisterButton.Depth = 0;
            RegisterButton.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            RegisterButton.HighEmphasis = true;
            RegisterButton.Icon = null;
            RegisterButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            RegisterButton.Location = new Point(49, 361);
            RegisterButton.Margin = new Padding(4, 6, 4, 6);
            RegisterButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            RegisterButton.Name = "RegisterButton";
            RegisterButton.NoAccentTextColor = Color.Empty;
            RegisterButton.Size = new Size(235, 36);
            RegisterButton.TabIndex = 14;
            RegisterButton.Text = "Register";
            RegisterButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            RegisterButton.UseAccentColor = false;
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // LoginButton
            // 
            LoginButton.AutoSize = false;
            LoginButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            LoginButton.CharacterCasing = ReaLTaiizor.Controls.MaterialButton.CharacterCasingEnum.Normal;
            LoginButton.Cursor = Cursors.Hand;
            LoginButton.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            LoginButton.Depth = 0;
            LoginButton.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 238);
            LoginButton.HighEmphasis = true;
            LoginButton.Icon = null;
            LoginButton.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            LoginButton.Location = new Point(49, 250);
            LoginButton.Margin = new Padding(4, 6, 4, 6);
            LoginButton.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            LoginButton.Name = "LoginButton";
            LoginButton.NoAccentTextColor = Color.Empty;
            LoginButton.Size = new Size(235, 36);
            LoginButton.TabIndex = 13;
            LoginButton.Text = "Login";
            LoginButton.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            LoginButton.UseAccentColor = true;
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(DVCAForm);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(1920, 1032);
            MinimumSize = new Size(190, 40);
            Name = "LoginForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "themeForm1";
            TransparencyKey = Color.Fuchsia;
            FormClosed += LoginForm_FormClosed;
            DVCAForm.ResumeLayout(false);
            DVCAForm.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.HopeTextBox EmailLoginTextBox;
        private ReaLTaiizor.Controls.HopeTextBox PasswordLoginTextBox;
        private ReaLTaiizor.Forms.NightForm DVCAForm;
        private ReaLTaiizor.Controls.MaterialLabel materialLabel1;
        private ReaLTaiizor.Controls.HopeSwitch LoginRememberMeSwitch;
        private ReaLTaiizor.Controls.MaterialButton RegisterButton;
        private ReaLTaiizor.Controls.MaterialButton LoginButton;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.MaterialLabel IncorrectCredentialsLabel;
        private ReaLTaiizor.Controls.MaterialButton GoOfflineModeButton;
    }
}
