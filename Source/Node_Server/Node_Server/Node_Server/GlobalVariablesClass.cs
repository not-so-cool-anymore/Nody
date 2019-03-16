using System;
using System.Collections.Generic;
namespace Node_Server
{
    public class GlobalVariables
    {
        public static int connectedNodesCounter = 0;
        public static int connectedClientsCounter = 0;
        public static int totalLoadCounter = 0;
        public static List<ConnectedNode> connectedNodes = new List<ConnectedNode>();
        public static List<ConnectedClient> connectedClients = new List<ConnectedClient>();
        public static List<int> nodesCachedIDs = new List<int>();
        public static List<int> clientsCachedIDs = new List<int>();
    }
}
