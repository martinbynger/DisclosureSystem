using System;
using System.Net.Sockets;

namespace Glenshield.Communication
{
    public class AuthenticatedTcpClient : IEquatable<AuthenticatedTcpClient>
    {

        private string clientID = "0";
        private string clientAuthentication = "";
        private int clientType = (int)Common.CommunicationClientType.None;
        public TcpClient tcpClient;

        public AuthenticatedTcpClient(Common.CommunicationAuthenticationData communicationAuthenticationData)
        {
            if (CanAuthenticateClient(communicationAuthenticationData))
            {
                ClientID = communicationAuthenticationData.ID;
                ClientAuthentication = communicationAuthenticationData.Authentication;
                ClientType = (int)communicationAuthenticationData.Type;
            }
        }

        public string ClientID
        {
            get
            {
                return clientID;
            }

            set
            {
                clientID = value;
            }
        }

        public string ClientAuthentication
        {
            get
            {
                return clientAuthentication;
            }

            set
            {
                clientAuthentication = value;
            }
        }

        public int ClientType
        {
            get
            {
                return clientType;
            }

            set
            {
                clientType = value;
            }
        }

        public bool IsAuthenticated()
        {
                return true;
        }

        private bool CanAuthenticateClient(Common.CommunicationAuthenticationData communicationAuthenticationData)
        {
            return true;
        }

        public override int GetHashCode()
        {
            return this.GetHashCode();
        }

        public bool Equals(AuthenticatedTcpClient obj)
        {
            
            if (obj != null)
            {
                return (this.clientID == obj.clientID);
            }
            else
            {
                return false;
            }

        }

    }
}
