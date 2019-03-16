using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Nody
{
    class HandleCommunicationClass
    {
        public static void SendData(string data)
        {
            if (GlobalVariablesClass.clientNetStream.CanWrite)
            {
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                GlobalVariablesClass.clientNetStream.Write(buffer, 0, buffer.Length);
            } 
        }
        public static string ReceiveData()
        {
            StringBuilder clientStr = new StringBuilder();

            byte[] buffer = new byte[2048];
            int bytesRead = 0;

            if (GlobalVariablesClass.clientNetStream.CanRead)
            {
                do
                {
                    bytesRead = GlobalVariablesClass.clientNetStream.Read(buffer, 0, 2048);

                    clientStr.AppendFormat("{0}", Encoding.ASCII.GetString(buffer, 0, bytesRead));


                } while (GlobalVariablesClass.clientNetStream.DataAvailable);

                return clientStr.ToString();
            }
            return "";
        }
    }
}
