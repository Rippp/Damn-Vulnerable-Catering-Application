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
    public partial class EncryptionForm : MaterialForm
    {
        public string EncryptionPassword = string.Empty;
        public EncryptionForm()
        {
            InitializeComponent();
        }

        private void EncryptionForm_Load(object sender, EventArgs e)
        {

        }

        private void materialTextBoxEdit1_TextChanged(object sender, EventArgs e)
        {
            if(materialTextBoxEdit1.Text.Length == 8)
            {
                materialButton2.Enabled = true;
                EncryptionPassword = materialTextBoxEdit1.Text;
            }
            else
            {
                materialButton2.Enabled = false;
            }
        }
    }
}
