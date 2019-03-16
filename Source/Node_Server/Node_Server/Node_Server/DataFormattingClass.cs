using System;
using System.Text;
using System.Net.Sockets;

using System.Collections.Generic;


namespace Node_Server
{
    public static class DataFormattingClass
    {
        public static string[] FormatReceivedFromNode(TcpClient client)
        {
            string receivedData = CommunicationHandling.ReadNodeData(client);
           
            //Splits the received to data type and data value
            string[] receivedDataArr = receivedData.Split(' ');

            receivedDataArr[0] = receivedDataArr[0].Remove(receivedDataArr[0].Length-1);

            return receivedDataArr;
        }
        public static string[] IncomingClientDataToArray(TcpClient client)
        {
            string[] requestSplitingKeywordChars = { "<!<Split Them Up>!>" };
            string[] keysSplitingKeywordChars = { "<key data>" };

            return keysSplitingKeywordChars; 
        }
    }
}
