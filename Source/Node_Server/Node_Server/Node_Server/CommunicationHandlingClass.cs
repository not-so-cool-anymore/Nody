using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace Node_Server
{
    public class CommunicationHandling
    {
        public static string ReadNodeData(TcpClient node)
        {
            StringBuilder receivedDataStr = new StringBuilder();

            NetworkStream connectionStream = node.GetStream();
            if (connectionStream.CanRead)
            {
                int bufferLength = 32;
                int bytesRead =  0;

                Console.WriteLine(">> Reading from NODE");

                byte[] buffer = new byte[bufferLength];

                bytesRead = connectionStream.Read(buffer, 0, bufferLength);

                receivedDataStr.Append(Encoding.ASCII.GetString(buffer, 0, bytesRead));

                Console.WriteLine(bytesRead);

                return receivedDataStr.ToString();
            }
            else
            {
                Console.WriteLine(">> Can't read");
                return "";
            }
        }
        public static string ReadClientData(TcpClient client)
        {
            StringBuilder clientStr = new StringBuilder();
            NetworkStream clientNetStream = client.GetStream();

            byte[] buffer = new byte[2048];
            int bytesRead = 0;

            if (clientNetStream.CanRead)
            {
                do
                {
                    bytesRead = clientNetStream.Read(buffer, 0, 2048);

                    clientStr.AppendFormat("{0}", Encoding.ASCII.GetString(buffer, 0, bytesRead));


                } while (clientNetStream.DataAvailable);

                return clientStr.ToString();
            }
            return "";
        }

        public static string TraceConnection(TcpClient connection)
        {
            string ipEndPoint = ((IPEndPoint)connection.Client.RemoteEndPoint).Address.ToString();

            return ipEndPoint;
        }
    }
}
