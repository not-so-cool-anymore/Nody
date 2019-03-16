using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nody
{
    public partial class EstablishConnectionForm : Form
    {
        public EstablishConnectionForm()
        {
            InitializeComponent();
        }
        private static void StartUpProcedure()
        {
            CryptoSecurityClass.GenerateCommunicationKeys();

            GloabalVariablesClass.client.Connect("172.26.17.203", 1025);
            GloabalVariablesClass.clientNetStream = GloabalVariablesClass.client.GetStream();

            string deviceName = System.Environment.MachineName;

            HandleCommunicationClass.SendData(deviceName);

        }
    
    }
}
