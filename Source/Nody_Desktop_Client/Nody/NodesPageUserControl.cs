using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nody
{
    public partial class NodesPageUserControl : UserControl
    {
        public static string[] cachedHumid;
        public static string[] cachedTemp;

        public NodesPageUserControl()
        {
            InitializeComponent();
        }
        static string[] GetAvailableNodes()
        {
            DataFormattingClass.SendRequest("seek-for-nodes", GlobalVariablesClass.username, GlobalVariablesClass.password);

            string securedServerResponse = HandleCommunicationClass.ReceiveData();
            string decryptedServerResponse = DataFormattingClass.DesecureServerResponse(securedServerResponse);

            if (decryptedServerResponse.Equals("102"))
            {
                MessageBox.Show("User is not valid, sign out and sign in again");

                return new string[] { };
            }
            else
            {
                string securedNodeCollection = HandleCommunicationClass.ReceiveData();
                string[] decryptedNodeCollection = DataFormattingClass.ServerCollectionToArray(securedNodeCollection);

                return decryptedNodeCollection;
            }
        }

        private void NodesList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            string[] availableNodes = GetAvailableNodes();

            for (int i = 0; i < availableNodes.Length; i++)
            {
                nodesList.Items.Add(string.Join(Environment.NewLine, availableNodes[i]));
            }
        }

        private  void SeekDataBtn_Click(object sender, EventArgs e)
        {
            if (nodesList.Items.Count<1)
            {
                MessageBox.Show("You haven't selected a node." + Environment.NewLine + "Pleas doubleclick the Nodes box to check if there are availabe ones.");
            }
            else
            {
                GetHumidity();
                GetTemperature();
                GetSound();
                CompareTempHum();
            }
        }

  
        public async void GetHumidity()
        {
            string nodeName = nodesList.GetItemText(nodesList.SelectedItem);

            Thread sendRequest = new Thread(() => DataFormattingClass.SendNodeDataRequest("get-humid", GlobalVariablesClass.username, GlobalVariablesClass.password, nodeName));
            sendRequest.Start();

            string securedServerResponse = HandleCommunicationClass.ReceiveData();
            string decryptedServerResponse = DataFormattingClass.DesecureServerResponse(securedServerResponse);

            if (decryptedServerResponse.Equals("102"))
            {
                MessageBox.Show("User is not valid, sign out and sign in again");
            }
            else
            {
                string securedNodeCollection = HandleCommunicationClass.ReceiveData();
                string[] decryptedNodeCollection = DataFormattingClass.ServerCollectionToArray(securedNodeCollection);

                cachedHumid = decryptedNodeCollection;

                for (int i = 0; i < decryptedNodeCollection.Length; i++)
                {
                    if (!decryptedNodeCollection[i].Equals(""))
                    {
                        humidityDataChart.Series["Humidity"].Points.AddXY(i + 1, float.Parse(decryptedNodeCollection.ToArray()[i]));
                    }
                }
            }
        }

        public void GetSound()
        {
            string nodeName = nodesList.GetItemText(nodesList.SelectedItem);


            Thread sendRequest = new Thread(() => DataFormattingClass.SendNodeDataRequest("get-sound", GlobalVariablesClass.username, GlobalVariablesClass.password, nodeName));
            sendRequest.Start();

            string securedServerResponse = HandleCommunicationClass.ReceiveData();
            string decryptedServerResponse = DataFormattingClass.DesecureServerResponse(securedServerResponse);

            if (decryptedServerResponse.Equals("102"))
            {
                MessageBox.Show("User is not valid, sign out and sign in again");
            }
            else
            {
                string securedNodeCollection = HandleCommunicationClass.ReceiveData();
                string[] decryptedNodeCollection = DataFormattingClass.ServerCollectionToArray(securedNodeCollection);

                for (int i = 0; i < decryptedNodeCollection.Length; i++)
                {
                    if (!decryptedNodeCollection[i].Equals(""))
                    {
                        soundDataChart.Series["Sound"].Points.AddXY(i + 1, float.Parse(decryptedNodeCollection.ToArray()[i]));
                    }
                }
            }
        }

        public void GetTemperature()
        {
            string nodeName = nodesList.GetItemText(nodesList.SelectedItem);

            Thread sendRequest = new Thread(() => DataFormattingClass.SendNodeDataRequest("get-temp", GlobalVariablesClass.username, GlobalVariablesClass.password, nodeName));
            sendRequest.Start();

            string securedServerResponse = HandleCommunicationClass.ReceiveData();
            string decryptedServerResponse = DataFormattingClass.DesecureServerResponse(securedServerResponse);

            if (decryptedServerResponse.Equals("102"))
            {
                MessageBox.Show("User is not valid, sign out and sign in again");
            }
            else
            {
                string securedNodeCollection = HandleCommunicationClass.ReceiveData();
                string[] decryptedNodeCollection = DataFormattingClass.ServerCollectionToArray(securedNodeCollection);

                cachedTemp = decryptedNodeCollection;

                for (int i = 0; i < decryptedNodeCollection.Length; i++)
                {
                    if (!decryptedNodeCollection[i].Equals(""))
                    {
                        tempDataChart.Series["Temperature"].Points.AddXY(i + 1, float.Parse(decryptedNodeCollection.ToArray()[i]));
                    }
                }
            }
        }

        public void CompareTempHum()
        {
            for (int i = 0; i < cachedTemp.Length; i++)
            {
                if (!cachedTemp[i].Equals(""))
                {
                    comparingChart.Series["Temperature"].Points.AddXY(i + 1, float.Parse(cachedTemp.ToArray()[i]));
                }
                if (!cachedHumid[i].Equals(""))
                {
                    comparingChart.Series["Humidity"].Points.AddXY(i + 1, float.Parse(cachedHumid.ToArray()[i]));
                }
            }
           
        }
    }
}