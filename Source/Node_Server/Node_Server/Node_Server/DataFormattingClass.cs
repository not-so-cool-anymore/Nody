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
            string[] keysSplitingKeyword = { "<key data>" };

            string receivedFullDataSegment = CommunicationHandling.ReadClientData(client);
            string[] receivedDataSegments = receivedFullDataSegment.Split(keysSplitingKeyword, StringSplitOptions.RemoveEmptyEntries);

            string securedSegmentZero = receivedDataSegments[0];

            string aesSecurityKeyZero = CryptoSecurityClass.RsaDecrypt(receivedDataSegments[1]);
            string aesSecurityKeyOne = CryptoSecurityClass.RsaDecrypt(receivedDataSegments[2]);

            string decryptedSegmentZero = CryptoSecurityClass.AesDecrypt(securedSegmentZero, ASCIIEncoding.ASCII.GetBytes(aesSecurityKeyZero));

            string[] request = decryptedSegmentZero.Split(requestSplitingKeywordChars, StringSplitOptions.RemoveEmptyEntries);

            return new string[] { request[0], request[1], aesSecurityKeyOne };
        }
        public static string[] SubDataToArray(string subData)
        {

            string[] splitingKeywordChars = { "<sub split>" };

            string[] subDataArray = subData.Split(splitingKeywordChars, StringSplitOptions.RemoveEmptyEntries);

            return subDataArray;
        }
    }
}
