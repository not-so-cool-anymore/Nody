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
            if (GloabalVariablesClass.clientNetStream.CanWrite)
            {
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                GloabalVariablesClass.clientNetStream.Write(buffer, 0, buffer.Length);
            } 
        }
        public static void ReceiveData(string data)
        {

        }
    }
}
