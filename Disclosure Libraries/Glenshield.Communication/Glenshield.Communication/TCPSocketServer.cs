using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Glenshield.Cryptography;

namespace Glenshield.Communication
{
    public class TCPSocketServer
    {
        public TcpListener tcpListner;

        private List<TcpClient> allConnectedClients;
        private List<AuthenticatedTcpClient> allAuthenticatedClients;
       
        public EventHandler<CommunicationMessage> RaiseClientConnectedEvent;
        public EventHandler<CommunicationMessage> RaiseTextReceivedEvent;
        public EventHandler<CommunicationMessage> RaiseClientDisconnectedEvent;

        public bool KeepRunning { get; set; }

        public TCPSocketServer()
        {
            allConnectedClients = new List<TcpClient>();
            allAuthenticatedClients = new List<AuthenticatedTcpClient>();
        }

        protected virtual void OnRaiseClientConnectedEvent(CommunicationMessage serverEventArguments)
        {
            RaiseClientConnectedEvent?.Invoke(this, serverEventArguments);
        }

        protected virtual void OnRaiseTextReceivedEvent(CommunicationMessage serverEventArguments)
        {
            RaiseTextReceivedEvent?.Invoke(this, serverEventArguments);
        }

        protected virtual void OnRaiseClientDisconnectedEvent(CommunicationMessage serverEventArguments)
        {
            RaiseClientDisconnectedEvent?.Invoke(this, serverEventArguments);
        }

        public async void StartListeningForIncomingConnection()
        {
            tcpListner = new TcpListener(IPAddress.Any, Common.SeverListeningOnPort);

            try
            {
                tcpListner.Start();
                KeepRunning = true;

                while (KeepRunning)
                {
                    try
                    {
                        TcpClient clientThatConnected = (TcpClient) await tcpListner.AcceptTcpClientAsync();
                        ReadMessageFromClientAsync(clientThatConnected);
                        OnRaiseClientConnectedEvent(new CommunicationMessage(null, Common.CommunicationEventType.Connected));
                    }
                    catch
                    {
                    }
                }
            }
            catch (Exception excp)
            {
               System.Diagnostics.Debug.WriteLine(excp.ToString());
            }
        }

        public void StopServer()
        {
            try
            {
                if (tcpListner != null)
                {
                    KeepRunning = false;
                    tcpListner.Stop();
                }

                foreach (AuthenticatedTcpClient authenticatedTcpClient in allAuthenticatedClients)
                {
                    authenticatedTcpClient.tcpClient.Close();
                }

                allAuthenticatedClients.Clear();

                foreach (TcpClient tcpClient in allConnectedClients)
                {
                    tcpClient.Close();
                }

                allConnectedClients.Clear();
            }
            catch
            {
                
            }
        }

        private async void ReadMessageFromClientAsync(TcpClient clientThatConnected)
        {
            try
            {
                NetworkStream stream = null;
                StreamReader reader = null;
                string readTextFromClient;
                char[] readBuffer = new char[Common.ReadBufferSize];

                stream = clientThatConnected.GetStream();
                reader = new StreamReader(stream, System.Text.Encoding.Unicode);

                while (KeepRunning)
                {
                    try
                    {
                        int numberOfCharsReturned = await reader.ReadAsync(readBuffer, 0, readBuffer.Length);

                        if (numberOfCharsReturned == Common.ClientDidDisconnect)
                        {
                            OnRaiseClientDisconnectedEvent(new CommunicationMessage(null, Common.CommunicationEventType.Disconnected));
                            RemoveClient(clientThatConnected);
                            break;
                        }

                        readTextFromClient = new string(readBuffer).Substring(0, numberOfCharsReturned);
                        HandleTextFromClient(CryptographyService.Decrypt(readTextFromClient), clientThatConnected);
                    }
                    catch
                    {

                    }
                    finally
                    {
                        Array.Clear(readBuffer, 0, readBuffer.Length);
                        readTextFromClient = "";
                    }
                }

            }
            catch
            {
                OnRaiseClientDisconnectedEvent(new CommunicationMessage(null, Common.CommunicationEventType.Disconnected));
                RemoveClient(clientThatConnected);
            }

        }

        private void HandleTextFromClient(string readTextFromClient, TcpClient clientThatConnected)
        {
            if (readTextFromClient != Common.UnicodeIdentifierCharacter)
            {
                CommunicationMessage receivedCommunicationMessage = new CommunicationMessage(readTextFromClient, Common.CommunicationEventType.TextReceived);

                if (receivedCommunicationMessage.MessageType == (int)Common.CommunicationMessageType.Login)
                {
                    AddAuthenticatedClient(receivedCommunicationMessage, clientThatConnected);
                }

                OnRaiseTextReceivedEvent(receivedCommunicationMessage);
            }
        }

        private void AddAuthenticatedClient(CommunicationMessage receivedCommunicationMessage, TcpClient clientThatConnected)
        {
            if (receivedCommunicationMessage.MessageType == (int)Common.CommunicationMessageType.Login)
            {
                Common.CommunicationAuthenticationData communicationAuthenticationData;
                communicationAuthenticationData.ID = receivedCommunicationMessage.SenderID;
                communicationAuthenticationData.Authentication = receivedCommunicationMessage.SenderAuthentication;
                communicationAuthenticationData.Type = (Common.CommunicationClientType)receivedCommunicationMessage.SenderType;

                AuthenticatedTcpClient authenticatedTcpClient = new AuthenticatedTcpClient(communicationAuthenticationData);

                if (authenticatedTcpClient.IsAuthenticated())
                {
                    allConnectedClients.Remove(clientThatConnected);
                    authenticatedTcpClient.tcpClient = clientThatConnected;
                    allAuthenticatedClients.Add(authenticatedTcpClient);
                }
                
            }
        }

        private void RemoveClient(TcpClient tcpClient)
        {
            try
            {
                if (allConnectedClients.Contains(tcpClient))
                {
                    allConnectedClients.Remove(tcpClient);
                }
            }
            catch
            {

            }
        }

        private void RemoveAuthenticatedClient(AuthenticatedTcpClient authenticatedTcpClient)
        {
            try
            {
                if (allAuthenticatedClients.Contains(authenticatedTcpClient))
                {
                    allAuthenticatedClients.Remove(authenticatedTcpClient);
                }
            }
            catch
            {

            }
        }

        public async void SendToAllConnectedClients(string textMessage)
        {
            try
            {
                if (string.IsNullOrEmpty(textMessage))
                {
                    return;
                }

                byte[] textMessageAsBytes = Encoding.Unicode.GetBytes(textMessage);

                foreach (TcpClient connectedTcpClient in allConnectedClients)
                {
                    connectedTcpClient.GetStream().WriteAsync(textMessageAsBytes, 0, textMessageAsBytes.Length);
                }

                Array.Clear(textMessageAsBytes, 0, textMessageAsBytes.Length);
            }
            catch
            {

            }

        }

        public void SendToAuthenticatedClient(CommunicationMessage communicationMessage)
        {
            byte[] textMessageAsBytes;

            try
            {
                AuthenticatedTcpClient clientToSendTo;
                textMessageAsBytes = Encoding.Unicode.GetBytes(CryptographyService.Encrypt(communicationMessage.BuildCommunicationMessageText()));
                
                clientToSendTo = allAuthenticatedClients.First(AuthenticatedTcpClient => AuthenticatedTcpClient.ClientID == communicationMessage.RecipientID);
                clientToSendTo.tcpClient.GetStream().WriteAsync(textMessageAsBytes, 0, textMessageAsBytes.Length);

                Array.Clear(textMessageAsBytes, 0, textMessageAsBytes.Length);
            }
            catch (Exception ex)
            {
                string s = ex.Message;
            }
        }

        public void SendToAllAuthenticatedClients(CommunicationMessage communicationMessage)
        {


        }

    }
}
