using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Security.Cryptography;

namespace Nody
{
    class GlobalVariablesClass
    {
        public static string username = String.Empty;
        public static string password = String.Empty;
        public static TcpClient client = new TcpClient();
        public static RSAParameters clientPrivateKey;
        public static string clientPublicKey = String.Empty;
        public static string serverPublicKey = String.Empty;
        public static NetworkStream clientNetStream;      
        
    }
}
