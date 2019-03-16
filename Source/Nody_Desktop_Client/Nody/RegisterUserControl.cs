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
    public partial class RegisterUserControl : UserControl
    {
        public RegisterUserControl()
        {
            InitializeComponent();
        }


        private void ChangePassCharsState(object sender, EventArgs e)
        {
            if (showCharCheckBox.Checked)
            {
                this.passwordTextBox.PasswordChar = '\0';
                this.repeatedPasswordTextBox.PasswordChar = '\0';
            }
            else
            {
                this.passwordTextBox.PasswordChar = '*';
                this.repeatedPasswordTextBox.PasswordChar = '*';
            }
        }

        private void RegisterBtn_Click(object sender, EventArgs e)
        {
            if (usernameTextBox.Text != "" && passwordTextBox.Text != "" && repeatedPasswordTextBox.Text != "")
            {
                if (passwordTextBox.Text != repeatedPasswordTextBox.Text)
                {
                    MessageBox.Show("Password and Repeated Password must be the same");
                }
                else
                {
                    string username = usernameTextBox.Text;
                    string password = passwordTextBox.Text;
                    bool isSuccessful = AccountAccessFunctionsClass.SendRegisterRequest(username, password);

                    if (isSuccessful == true)
                    {
                        usernameTextBox.Clear();
                        passwordTextBox.Clear();
                        repeatedPasswordTextBox.Clear();
                    }                    
                }
                
            }
            else
            {
                MessageBox.Show("Username, Password and Repeated Password can't be empty");
            }
        }

    }
}
