using System;
using System.Net.Sockets;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Node_Server
{
    public class NodePrivateThread
    {
        public static void CollectData(TcpClient node, string name, string location)
        {
            
            try
            {
                while (true)
                {
                    string[] receivedData = DataFormattingClass.FormatReceivedFromNode(node);
                    string dataType = receivedData[0];
                    string dataValue = receivedData[1];

                    Console.WriteLine(">> " + dataType);

                    if (dataType.Equals("temp"))
                    {

                        try
                        {
                            float tempValueAsFloat = float.Parse(dataValue);
                            GlobalVariablesClass.connectedNodes.First(cNode => cNode.Name.Equals(name)).cachedTempData.Add(tempValueAsFloat);
                            File.AppendAllText(@"\nodes\" + name + "00" + location + "temp.txt", dataValue + Environment.NewLine);
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                    else if (dataType.Equals("humid"))
                    {
                        try
                        {
                            float humidValueAsFloat = float.Parse(dataValue);
                            GlobalVariablesClass.connectedNodes.First(cNode => cNode.Name.Equals(name)).cachedHumidData.Add(humidValueAsFloat);
                            File.AppendAllText(@"\nodes\" + name + "00" + location + "humid.txt", dataValue + Environment.NewLine);
                        }
                        catch (Exception ex)
                        {
                        }
                    }
                    else if (dataType.Equals("sound"))
                    {
                        try {
                            GlobalVariablesClass.connectedNodes.First(cNode => cNode.Name.Equals(name)).cachedSoundData.Add(float.Parse(dataValue));
                            File.AppendAllText(@"\nodes\" + name + "00" + location + "sound.txt", dataValue + Environment.NewLine);
                        }
                        catch(Exception ex)
                        {
                        }
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
            int clientId = GlobalVariablesClass.connectedNodes.First(node => node.Name.Equals(name)).Id;

            GlobalVariablesClass.connectedNodes.Remove(GlobalVariablesClass.connectedNodes.First(node => node.Name.Equals(name)));
            GlobalVariablesClass.nodesCachedIDs.Add(clientId);

            Console.WriteLine(">> NODE disconnected the server");
        }
    }
}
