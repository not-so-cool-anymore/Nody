using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nody
{
    public partial class EstablishConnectionForm : Form
    {
        public EstablishConnectionForm()
        {
            InitializeComponent();
            try
            {
                CryptoSecurityClass.GenerateCommunicationKeys();

                GlobalVariablesClass.client.Connect("172.26.17.203", 1025);
                
                GlobalVariablesClass.clientNetStream = GlobalVariablesClass.client.GetStream();

                CryptoSecurityClass.SyncCommunicationKeys();

                string deviceName = System.Environment.MachineName;

                HandleCommunicationClass.SendData(deviceName);
                
                Nody_Auth authForm = new Nody_Auth();
                authForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
