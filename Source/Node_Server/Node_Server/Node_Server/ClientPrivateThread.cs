using System;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Collections.Generic;
namespace Node_Server
{
    public class ClientPrivateThread
    {
        public static void HandleClientRequest(TcpClient client, int id)
        {
            try
            {
                while (true)
                {
                    string[] requestData = DataFormattingClass.IncomingClientDataToArray(client);
                    string request = requestData[0];
                    string requestSubData = requestData[1];
                    string aesSecurityKeyOne = requestData[2];

                    if (request.ToLower().Equals("login"))
                    {
                        string[] loginSubDataArray = DataFormattingClass.SubDataToArray(requestSubData);
                        string username = CryptoSecurityClass.RsaDecrypt(loginSubDataArray[0]);
                        string password = CryptoSecurityClass.RsaDecrypt(loginSubDataArray[1]);
                        string clientPublicKey = CryptoSecurityClass.AesDecrypt(loginSubDataArray[2], ASCIIEncoding.ASCII.GetBytes(aesSecurityKeyOne));

                        if (DatabaseFunctions.ValidateUser(username, password) == true)
                        {
                            Console.WriteLine(">> Client was validated successfuly");
                            CommunicationHandling.SendToClient(client, CryptoSecurityClass.RsaEncrypt("101", clientPublicKey));
                        }
                        else
                        {
                            CommunicationHandling.SendToClient(client, CryptoSecurityClass.RsaEncrypt("102", clientPublicKey));
                        }
                    }
                    else if (request.ToLower().Equals("reg"))
                    {
                        string[] loginSubDataArray = DataFormattingClass.SubDataToArray(requestSubData);
                        string username = CryptoSecurityClass.RsaDecrypt(loginSubDataArray[0]);
                        string password = CryptoSecurityClass.RsaDecrypt(loginSubDataArray[1]);
                        string clientPublicKey = CryptoSecurityClass.AesDecrypt(loginSubDataArray[2], ASCIIEncoding.ASCII.GetBytes(aesSecurityKeyOne));

                        if (!DatabaseFunctions.CheckUserDuplicating(username))
                        {
                            string passwordSalt = CryptoSecurityClass.GenerateKey(16);
                            string hashedPassword = CryptoSecurityClass.HashPassword(password, passwordSalt);

                            DatabaseFunctions.InsertUser(username, hashedPassword, passwordSalt);
                            CommunicationHandling.SendToClient(client, CryptoSecurityClass.RsaEncrypt("104", clientPublicKey));
                        }
                        else
                        {
                            CommunicationHandling.SendToClient(client, CryptoSecurityClass.RsaEncrypt("105", clientPublicKey)); //There is a user with that username
                        }

                    }
                    else if (request.ToLower().Equals("seek-for-nodes"))
                    {
                        string[] loginSubDataArray = DataFormattingClass.SubDataToArray(requestSubData);
                        string username = CryptoSecurityClass.RsaDecrypt(loginSubDataArray[0]);
                        string password = CryptoSecurityClass.RsaDecrypt(loginSubDataArray[1]);
                        string clientPublicKey = CryptoSecurityClass.AesDecrypt(loginSubDataArray[2], ASCIIEncoding.ASCII.GetBytes(aesSecurityKeyOne));


                        if (DatabaseFunctions.ValidateUser(username, password) == true)
                        {
                            Console.WriteLine(">> Client was validated successfuly");
                            CommunicationHandling.SendToClient(client, CryptoSecurityClass.RsaEncrypt("101", clientPublicKey));

                            string nodes = "";

                            for (int i = 0; i < GlobalVariablesClass.connectedNodes.Count; i++)
                            {
                                nodes += GlobalVariablesClass.connectedNodes[i].Name + "<data>";
                            }

                            string aesCommKey = CryptoSecurityClass.GenerateKey(32);

                            string securedOutgoingData = CryptoSecurityClass.AesEncrypt(ASCIIEncoding.ASCII.GetBytes(nodes), ASCIIEncoding.ASCII.GetBytes(aesCommKey));

                            string securedOutgoingString = securedOutgoingData + "<key data>" + CryptoSecurityClass.RsaEncrypt(aesCommKey, clientPublicKey);

                            CommunicationHandling.SendToClient(client, securedOutgoingString);
                        }
                        else
                        {
                            CommunicationHandling.SendToClient(client, CryptoSecurityClass.RsaEncrypt("102", clientPublicKey));
                        }
                    }
                    else if (request.ToLower().Equals("get-humid"))
                    {
                        string[] loginSubDataArray = DataFormattingClass.SubDataToArray(requestSubData);
                        string username = CryptoSecurityClass.RsaDecrypt(loginSubDataArray[0]);
                        string password = CryptoSecurityClass.RsaDecrypt(loginSubDataArray[1]);
                        string nodeName = CryptoSecurityClass.RsaDecrypt(loginSubDataArray[2]);
                        string clientPublicKey = CryptoSecurityClass.AesDecrypt(loginSubDataArray[3], ASCIIEncoding.ASCII.GetBytes(aesSecurityKeyOne));


                        if (DatabaseFunctions.ValidateUser(username, password) == true)
                        {
                            Console.WriteLine(">> Client was validated successfuly");
                            CommunicationHandling.SendToClient(client, CryptoSecurityClass.RsaEncrypt("101", clientPublicKey));

                            List<float> nodeHumidData = GlobalVariablesClass.connectedNodes.First(node => node.Name.Equals(nodeName)).cachedHumidData;
                            string tempData = "";

                            for (int i = 0; i < nodeHumidData.Count/2; i++)
                            {
                                tempData += nodeHumidData[i] + "<data>";
                            }

                            string aesCommKey = CryptoSecurityClass.GenerateKey(32);

                            string securedOutgoingData = CryptoSecurityClass.AesEncrypt(ASCIIEncoding.ASCII.GetBytes(tempData), ASCIIEncoding.ASCII.GetBytes(aesCommKey));

                            string securedOutgoingString = securedOutgoingData + "<key data>" + CryptoSecurityClass.RsaEncrypt(aesCommKey, clientPublicKey);

                            CommunicationHandling.SendToClient(client, securedOutgoingString);
                        }
                        else
                        {
                            CommunicationHandling.SendToClient(client, CryptoSecurityClass.RsaEncrypt("102", clientPublicKey));
                        }
                    }
                    else if (request.ToLower().Equals("get-temp"))
                    {
                        string[] loginSubDataArray = DataFormattingClass.SubDataToArray(requestSubData);
                        string username = CryptoSecurityClass.RsaDecrypt(loginSubDataArray[0]);
                        string password = CryptoSecurityClass.RsaDecrypt(loginSubDataArray[1]);
                        string nodeName = CryptoSecurityClass.RsaDecrypt(loginSubDataArray[2]);
                        string clientPublicKey = CryptoSecurityClass.AesDecrypt(loginSubDataArray[3], ASCIIEncoding.ASCII.GetBytes(aesSecurityKeyOne));


                        if (DatabaseFunctions.ValidateUser(username, password) == true)
                        {
                            Console.WriteLine(">> Client was validated successfuly");
                            CommunicationHandling.SendToClient(client, CryptoSecurityClass.RsaEncrypt("101", clientPublicKey));

                            List<float> nodeTempData = GlobalVariablesClass.connectedNodes.First(node => node.Name.Equals(nodeName)).cachedTempData;
                            string tempData = "";

                            for (int i = 0; i < nodeTempData.Count / 2; i++)
                            {
                                tempData += nodeTempData[i] + "<data>";
                            }

                            string aesCommKey = CryptoSecurityClass.GenerateKey(32);

                            string securedOutgoingData = CryptoSecurityClass.AesEncrypt(ASCIIEncoding.ASCII.GetBytes(tempData), ASCIIEncoding.ASCII.GetBytes(aesCommKey));

                            string securedOutgoingString = securedOutgoingData + "<key data>" + CryptoSecurityClass.RsaEncrypt(aesCommKey, clientPublicKey);

                            CommunicationHandling.SendToClient(client, securedOutgoingString);
                        }
                        else
                        {
                            CommunicationHandling.SendToClient(client, CryptoSecurityClass.RsaEncrypt("102", clientPublicKey));
                        }
                    }
                    else if (request.ToLower().Equals("get-sound"))
                    {
                        string[] loginSubDataArray = DataFormattingClass.SubDataToArray(requestSubData);
                        string username = CryptoSecurityClass.RsaDecrypt(loginSubDataArray[0]);
                        string password = CryptoSecurityClass.RsaDecrypt(loginSubDataArray[1]);
                        string nodeName = CryptoSecurityClass.RsaDecrypt(loginSubDataArray[2]);
                        string clientPublicKey = CryptoSecurityClass.AesDecrypt(loginSubDataArray[3], ASCIIEncoding.ASCII.GetBytes(aesSecurityKeyOne));


                        if (DatabaseFunctions.ValidateUser(username, password) == true)
                        {
                            Console.WriteLine(">> Client was validated successfuly");
                            CommunicationHandling.SendToClient(client, CryptoSecurityClass.RsaEncrypt("101", clientPublicKey));

                            List<float> nodeSoundData = GlobalVariablesClass.connectedNodes.First(node => node.Name.Equals(nodeName)).cachedSoundData;
                            string tempData = "";

                            for (int i = 0; i < nodeSoundData.Count / 2; i++)
                            {
                                tempData += nodeSoundData[i] + "<data>";
                            }

                            string aesCommKey = CryptoSecurityClass.GenerateKey(32);

                            string securedOutgoingData = CryptoSecurityClass.AesEncrypt(ASCIIEncoding.ASCII.GetBytes(tempData), ASCIIEncoding.ASCII.GetBytes(aesCommKey));

                            string securedOutgoingString = securedOutgoingData + "<key data>" + CryptoSecurityClass.RsaEncrypt(aesCommKey, clientPublicKey);

                            CommunicationHandling.SendToClient(client, securedOutgoingString);
                        }
                        else
                        {
                            CommunicationHandling.SendToClient(client, CryptoSecurityClass.RsaEncrypt("102", clientPublicKey));
                        }
                    }
                    else if (request.ToLower().Equals("carbon-oxi"))
                    {

                    }
                    else
                    {
                        Console.WriteLine(">> CLIENT{0} made an invalid request -> {1}", id, request);
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                RemoveClient(id);
            }
        }
        public static void RemoveClient(int id)
        {
            GlobalVariablesClass.connectedClients.Remove(GlobalVariablesClass.connectedClients.First(client => client.Id == id ));
            GlobalVariablesClass.clientsCachedIDs.Add(id);

            Console.WriteLine(">> CLIENT disconnected from the server");
        }
    }
}
