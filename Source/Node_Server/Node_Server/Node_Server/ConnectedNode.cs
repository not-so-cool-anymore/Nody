using System;
using System.Net.Sockets;
using System.Collections.Generic;
namespace Node_Server
{
    public class ConnectedNode
    {
        public bool IsActivated;
        public int Id;
        public string Name;
        public string Location;
        public string Owner;
        public string IpEndPoint;
        public TcpClient nodeConnection;
        public List<float> cachedHumidData = new List<float>();
        public List<float> cachedTempData = new List<float>();
        public List<string> cachedSoundData = new List<string>();

        public ConnectedNode(bool isActivated, int id, string name, string location, string owner, string ipEndPoint)
        {
            IsActivated = isActivated;
            Id = id;
            Name = name;
            Location = location;
            Owner = owner;
            IpEndPoint = ipEndPoint;
        }
    }
}
