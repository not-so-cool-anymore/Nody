using System;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Node_Server
{
    public class ClientsServer
    {
        private static TcpListener clientListeningServer;
        private static readonly IPAddress clientListeningServerIP = IPAddress.Parse("172.26.17.109");
        public static void SetupClientsServer()
        {
            clientListeningServer = new TcpListener(clientListeningServerIP, 1025);
            clientListeningServer.Start();

            Console.WriteLine(">> The clients listening server has started");

            while (true)
            {

                TcpClient node = clientListeningServer.AcceptTcpClient();

                //Checks if there is a free cached id
                bool hasCached = GlobalVariables.clientsCachedIDs.Any();

                GlobalVariables.totalLoadCounter++;

                //Gives the free cached id to the client (if there is one)
                if (hasCached == true)
                {
                    Thread acceptConnThr = new Thread(() => AcceptConnectionRequest(
                    node,
                    GlobalVariables.clientsCachedIDs[0], true));

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
                    GlobalVariables.connectedClientsCounter++, false));

                    //Starts the acceptance thread
                    acceptConnThr.Start();
                }
            }
        }
        public static void AcceptConnectionRequest(TcpClient clientConnection, int id, bool isCached)
        {
            if (isCached == true)
            {
                //Removes the id from the cached ids list, because it was given to a connection
                GlobalVariables.clientsCachedIDs.RemoveAt(0);
                Console.WriteLine(">> Cached value was given to CLIENT with ID: " + id);
            }

            Console.WriteLine(">> CLIENT was connected: " + id);

            //Receives the info about the node system (name, owner, location, etc.)
            string clientName = CommunicationHandling.ReadNodeData(clientConnection);
            string clientIpEndPoint = CommunicationHandling.TraceConnection(clientConnection);

            //Creates new ConnectedNode
            ConnectedClient client = new ConnectedClient(
                id,
                clientName,
                clientIpEndPoint,
                false
            );

            GlobalVariables.connectedClients.Add(client);

            for (int i = 0; i < GlobalVariables.connectedClients.Count; i++)
            {
                ConnectedClient currClient = GlobalVariables.connectedClients[i];
                Console.WriteLine(">> CLIENT loop");

                if (currClient.IsActivated == false)
                {
                    Console.WriteLine(">> Activating CLIENT: " + id);

                    Thread clientPrivateThread = new Thread(() => ClientPrivateThread.HandleClientRequest(clientConnection, id));
                    clientPrivateThread.Start();

                    GlobalVariables.connectedClients[i].IsActivated = true;
                    Console.WriteLine(">> CLIENT was activated");
                }
            }
        }
    }
}