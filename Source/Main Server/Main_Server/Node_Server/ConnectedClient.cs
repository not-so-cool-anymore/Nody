using System;
namespace Node_Server
{
    public class ConnectedClient
    {
        public int Id;
        string Name;
        string IpEndPoint;
        public bool IsActivated;

        public ConnectedClient(int id, string name, string ipEndPoint, bool isActivated)
        {
            Id = id;
            Name = name;
            IpEndPoint = ipEndPoint;
            IsActivated = isActivated;
        }
    }
}
