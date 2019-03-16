using System;
using System.IO;
using System.Text;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Node_Server
{
    class NodesServer
    {
        private static TcpListener nodesListeningServer;
        private static readonly IPAddress nodesListeningServerIP = IPAddress.Parse("172.26.17.203");
        public static void SetupNodeServer()
        {
            nodesListeningServer = new TcpListener(nodesListeningServerIP, 1024);
            nodesListeningServer.Start();

            Console.WriteLine(">> The nodes listening server has started");

            while (true)
            {
                TcpClient node = nodesListeningServer.AcceptTcpClient();

                //Checks if there is a free cached id
                bool hasCached = GlobalVariablesClass.nodesCachedIDs.Any();

                GlobalVariablesClass.totalLoadCounter++;

                //Gives the free cached id to the client (if there is one)
                if (hasCached == true) 
                {
                    Thread acceptConnThr = new Thread(() => AcceptConnectionRequest(
                    node,
                    GlobalVariablesClass.nodesCachedIDs[0], true));

                    acceptConnThr.Start();
                }
                else
                {

                    /*
                      Creates new acceptance thread and gives the (connected 
                      clients counter vaulue + 1) as a connection id
                    */
                    Thread acceptConnThr = new Thread(() => AcceptConnectionRequest(
                    node,
                    GlobalVariablesClass.connectedNodesCounter++, false));

                    //Starts the acceptance thread
                    acceptConnThr.Start();
                }
            }
        }
        public static void AcceptConnectionRequest(TcpClient nodeConnection, int id, bool isCached)
        {
            if (isCached == true)
            {
                //Removes the id from the cached ids list, because it was given to a connection
                GlobalVariablesClass.nodesCachedIDs.RemoveAt(0);
                Console.WriteLine(">> Cached value was given to NODE with ID: " + id);
            }

            Console.WriteLine(">> NODE was connected: " + id);

            //Receives the info about the node system (name, owner, location, etc.)
            string nodeLocation = CommunicationHandling.ReadNodeData(nodeConnection);
            string nodeName = CommunicationHandling.ReadNodeData(nodeConnection);
            string nodeOwner = CommunicationHandling.ReadNodeData(nodeConnection);
            string nodeIpEndPoint = CommunicationHandling.TraceConnection(nodeConnection);

            if (!Directory.Exists(@"\nodes\" + nodeName + "<-->" + nodeLocation))
            {
                Directory.CreateDirectory(@"\nodes\" + nodeName + "<-->" + nodeLocation);
                File.Create(@"\nodes\" + nodeName + "<-->" + nodeLocation + "humid.txt");
                File.Create(@"\nodes\" + nodeName + "<-->" + nodeLocation + "temp.txt");
                File.Create(@"\nodes\" + nodeName + "<-->" + nodeLocation + "sound.txt");

            }
            //Creates new ConnectedNode
            ConnectedNode node = new ConnectedNode(
            false,
            id,
            nodeName,
            nodeLocation,
            nodeOwner,
            nodeIpEndPoint
            );           
            
            GlobalVariablesClass.connectedNodes.Add(node);

            for (int i = 0; i < GlobalVariablesClass.connectedNodes.Count; i++)
            {
                ConnectedNode currNode = GlobalVariablesClass.connectedNodes[i];
                Console.WriteLine(">> NODE loop");

                if (currNode.IsActivated == false)
                {
                    Console.WriteLine(">> Activating NODE: " + id);

                    Thread nodePrivateThread = new Thread(() => NodePrivateThread.CollectData(nodeConnection, nodeName, nodeLocation));
                    nodePrivateThread.Start();

                    GlobalVariablesClass.connectedNodes[i].IsActivated = true;
                    Console.WriteLine(">> NODE was activated");
                }
            }
        }

    }
}
