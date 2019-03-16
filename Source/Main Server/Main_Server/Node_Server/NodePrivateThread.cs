using System;
using System.Net.Sockets;
using System.Collections.Generic;
using System.Linq;
namespace Node_Server
{
    public class NodePrivateThread
    {
        public static void CollectData(TcpClient node, string name)
        {
            try
            {
                while (true)
                {
                    string[] receivedData = DataFormattingClass.FormatReceivedFromNode(node);
                    string dataType = receivedData[0];
                    string dataValue = receivedData[1];
                    Console.WriteLine(dataType);
                    if (dataType.Equals("temp"))
                    {
                        float tempValueAsFloat = float.Parse(dataValue);
                        GlobalVariables.connectedNodes.First(cNode => cNode.Name.Equals(name)).cachedTempData.Add(tempValueAsFloat);
                    }
                    else if (dataType.Equals("humid"))
                    {
                        float humidValueAsFloat = float.Parse(dataValue);
                        GlobalVariables.connectedNodes.First(cNode => cNode.Name.Equals(name)).cachedHumidData.Add(humidValueAsFloat);
                    }
                    else if (dataType.Equals("sound"))
                    {
                        GlobalVariables.connectedNodes.First(cNode => cNode.Name.Equals(name)).cachedSoundData.Add(dataValue);
                    }
                    else
                    {
                        Console.WriteLine(">> Something went horribly wrong. Run away while you still can");
                    }
                }
            }
            catch (Exception ex)
            {
                RemoveNode(name);
                Console.WriteLine(ex);
            }
        }
        public static void RemoveNode(string name)
        {
            int clientId = GlobalVariables.connectedNodes.First(node => node.Name.Equals(name)).Id;

            GlobalVariables.connectedNodes.Remove(GlobalVariables.connectedNodes.First(node => node.Name.Equals(name)));
            GlobalVariables.nodesCachedIDs.Add(clientId);

            Console.WriteLine(">> NODE disconnected the server");
        }
    }
}
