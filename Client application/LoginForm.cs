using DamnVulnerableCateringApplication.DataObjects;
using ReaLTaiizor.UI;
using System.Configuration;
using Microsoft.Win32;

namespace DamnVulnerableCateringApplication
{
    public partial class LoginForm : Form
    {
        private MainForm mainForm;
        private RegisterForm registerForm;

        public Client CurrentClient { get; set; }
        public LoginForm()
        {
            InitializeComponent();

            RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\RememberedUser");
            if (key != null)
            {
                string myValue = key.GetValue("MySetting")?.ToString();

                EmailLoginTextBox.Text = key.GetValue("Login")?.ToString() ?? string.Empty;
                PasswordLoginTextBox.Text = key.GetValue("Password")?.ToString() ?? string.Empty;

                key.Close();
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (HTTPHandler.Authenticate(EmailLoginTextBox.Text, PasswordLoginTextBox.Text))
            {
                IncorrectCredentialsLabel.Visible = false;
                RegistryKey key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\RememberedUser");

                // Zapisanie w rejestrze
                if (LoginRememberMeSwitch.Checked)
                {
                    if (key != null)
                    {
                        key.SetValue("Login", EmailLoginTextBox.Text);
                        key.SetValue("Password", PasswordLoginTextBox.Text);
                        key.Close();
                    }
                }
                // Usuniêcie z rejestru
                else
                {
                    if (key != null)
                    {
                        key.DeleteValue("Login", throwOnMissingValue: false);
                        key.DeleteValue("Password", throwOnMissingValue: false);
                        key.Close();
                    }
                }

                TransferToMainForm();
            }
            else
            {
                IncorrectCredentialsLabel.Visible = true;
            }
        }

        private void RegisterButton_Click(object sender, EventArgs e) { TransferToRegisterForm(); }

        private void materialLabel1_Click(object sender, EventArgs e)
        {
            LoginRememberMeSwitch.Checked = !LoginRememberMeSwitch.Checked;
        }

        public void TransferToMainForm(Client currentClient = null, bool isOffline = false)
        {
            mainForm = new MainForm(this, currentClient, isOffline);
            this.Hide();
            mainForm.ShowDialog();
        }

        private void TransferToRegisterForm()
        {
            registerForm = new RegisterForm(this);
            this.Hide();
            registerForm.ShowDialog();
        }

        public void ShowForm()
        {
            this.Show();
        }

        public void CloseAllForms(bool closeLogin = true)
        {
            mainForm?.Close();
            registerForm?.Close();
            if (closeLogin)
                this.Close();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseAllForms(false);
        }

        private void GoOfflineModeButton_Click(object sender, EventArgs e)
        {
            TransferToMainForm(isOffline: true);
        }
    }
}
