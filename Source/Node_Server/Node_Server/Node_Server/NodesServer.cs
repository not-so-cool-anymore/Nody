using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Net;
using System.Net.Sockets;

namespace Node_Server
{
    class NodesServer
    {
        private static TcpListener nodesListeningServer;
        private static readonly IPAddress nodesListeningServerIP = IPAddress.Parse("172.26.17.109");
        public static void SetupNodeServer()
        {
            nodesListeningServer = new TcpListener(nodesListeningServerIP, 1024);
            nodesListeningServer.Start();

            Console.WriteLine(">> The nodes listening server has started");

            while (true)
            {
                TcpClient node = nodesListeningServer.AcceptTcpClient();

                //Checks if there is a free cached id
                bool hasCached = GlobalVariables.nodesCachedIDs.Any();

                GlobalVariables.totalLoadCounter++;

                //Gives the free cached id to the client (if there is one)
                if (hasCached == true) 
                {
                    Thread acceptConnThr = new Thread(() => AcceptConnectionRequest(
                    node,
                    GlobalVariables.nodesCachedIDs[0], true));

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
                    GlobalVariables.connectedNodesCounter++, false));

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
                GlobalVariables.nodesCachedIDs.RemoveAt(0);
                Console.WriteLine(">> Cached value was given to NODE with ID: " + id);
            }

            Console.WriteLine(">> NODE was connected: " + id);

            //Receives the info about the node system (name, owner, location, etc.)
            string nodeLocation = CommunicationHandling.ReadNodeData(nodeConnection);
            string nodeName = CommunicationHandling.ReadNodeData(nodeConnection);
            string nodeOwner = CommunicationHandling.ReadNodeData(nodeConnection);
            string nodeIpEndPoint = CommunicationHandling.TraceConnection(nodeConnection);

            //Creates new ConnectedNode
            ConnectedNode node = new ConnectedNode(
            false,
            id,
            nodeName,
            nodeLocation,
            nodeOwner,
            nodeIpEndPoint
            );

            Console.WriteLine(nodeName);
            Console.WriteLine(nodeLocation);
            Console.WriteLine(nodeOwner);
            Console.WriteLine(nodeIpEndPoint);
            
            GlobalVariables.connectedNodes.Add(node);

            for (int i = 0; i < GlobalVariables.connectedNodes.Count; i++)
            {
                ConnectedNode currNode = GlobalVariables.connectedNodes[i];
                Console.WriteLine(">> NODE loop");

                if (currNode.IsActivated == false)
                {
                    Console.WriteLine(">> Activating NODE: " + id);

                    Thread nodePrivateThread = new Thread(() => NodePrivateThread.CollectData(nodeConnection, nodeName));
                    nodePrivateThread.Start();

                    GlobalVariables.connectedNodes[i].IsActivated = true;
                    Console.WriteLine(">> NODE was activated");
                }
            }
        }

    }
}
