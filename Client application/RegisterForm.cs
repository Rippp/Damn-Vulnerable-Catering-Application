using DamnVulnerableCateringApplication.DataObjects;
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
    public partial class RegisterForm : Form
    {
        private readonly LoginForm _loginForm;
        public RegisterForm(LoginForm loginForm)
        {
            this._loginForm = loginForm;
            InitializeComponent();
        }

        private void BackToLoginButton_Click(object sender, EventArgs e)
        {
            _loginForm.ShowForm();
            this.Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            EmailErrorLabel.Visible = false;
            if (!ValidatePasswords()) return;

            var client = new Client
            {
                Email = EmailBox.Text,
                Name = NameBox.Text,
                Surname = SurnameBox.Text,
                Telephone = TelephoneBox.Text,
                Password = PasswordBox.Text,
                Address = new Address
                {
                    Street = StreetBox.Text,
                    StreetNo = BuildingNumberBox.Text,
                    Postal = PostalCodeBox.Text,
                    City = CityBox.Text
                }
            };

            if (HTTPHandler.Register(client))
            {
                _loginForm.TransferToMainForm(client);
                this.Close();
            }
            else
            {
                EmailErrorLabel.Visible = true;
            }
        }

        private bool ValidatePasswords()
        {
            PasswordErrorLabel.Visible = false;
            bool arePasswordsEqual = (PasswordBox.Text == RepeatPasswordBox.Text);
            if (!arePasswordsEqual)
                PasswordErrorLabel.Visible = true;

            return arePasswordsEqual;
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _loginForm.CloseAllForms();
        }
    }
}
