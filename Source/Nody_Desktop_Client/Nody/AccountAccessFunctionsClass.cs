using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nody
{
    class AccountAccessFunctionsClass
    {
        public static bool SendLoginRequest(string username, string password)
        {

            DataFormattingClass.SendRequest("login", username, password);

            string securedServerResponse = HandleCommunicationClass.ReceiveData();
            string decryptedServerResponse = DataFormattingClass.DesecureServerResponse(securedServerResponse);

            if (decryptedServerResponse.Equals("101")) // User is validated successfuly
            {
                MessageBox.Show("User was successfuly authenticated");
                
                GlobalVariablesClass.username = username;
                GlobalVariablesClass.password = password;

                return true;
            }
            else
            {
                MessageBox.Show("User does not exist");
                return false;
            }
        }
        public static bool SendRegisterRequest(string username, string password)
        {
            DataFormattingClass.SendRequest("reg", username, password);

            string securedServerResponse = HandleCommunicationClass.ReceiveData();
            string decryptedServerResponse = DataFormattingClass.DesecureServerResponse(securedServerResponse);

            if (decryptedServerResponse.Equals("104"))
            {
                MessageBox.Show("The account was created successfuly");
                return true;
            }
            else
            {
                MessageBox.Show("User already exists");
                return false;
            }
        }
    }
}
