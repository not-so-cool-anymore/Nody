using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nody
{
    public partial class LoginUserControl : UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();           
        }

        private void ChangePassCharsState(object sender, EventArgs e)
        {
            if (showCharCheckBox.Checked)
            {
                this.passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                this.passwordTextBox.PasswordChar = '*';                
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text.Equals("") || passwordTextBox.Text.Equals(""))
            {
                MessageBox.Show("Username and Password can't be empty");
            }
            else
            {
                bool isSuccessful = AccountAccessFunctionsClass.SendLoginRequest(usernameTextBox.Text, passwordTextBox.Text);

                if (isSuccessful)
                {
                    
                    NodyMainForm mainForm = new NodyMainForm();
                    
                    Form parentOfCurrent = this.FindForm();
                    parentOfCurrent.Close();
                    parentOfCurrent.Dispose();

                    mainForm.ShowDialog();
                } 
            }
        }
    }
}
