using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace Node_Server
{
    class MainClass
    {     
        public static void Main(string[] args)
        {
            //Generates the server RSA key pair
            CryptoSecurityClass.GenerateCommunicationKeys();
            Console.WriteLine(">> Key pair was generated");

            //Starts the nodes server in a separate thread
            Thread nodesServer = new Thread(NodesServer.SetupNodeServer);
            nodesServer.Start();

            //Starts the clients server in a separate thread
            Thread clientsServer = new Thread(ClientsServer.SetupClientsServer);
            clientsServer.Start();

            Console.WriteLine(">> Main setup was passed");
        }

    }
}   