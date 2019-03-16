using System;
using System.Linq;
using System.Net.Sockets;
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

                }

            }
            catch (Exception ex)
            {
                RemoveClient(id);
            }
        }
        public static void RemoveClient(int id)
        {
            GlobalVariables.connectedClients.Remove(GlobalVariables.connectedClients.First(client => client.Id == id ));
            GlobalVariables.clientsCachedIDs.Add(id);

            Console.WriteLine(">> CLIENT disconnected the server");
        }
    }
}
