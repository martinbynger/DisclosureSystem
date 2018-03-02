using System;
using System.Net;
using System.Net.Sockets;
using Glenshield.Communication;
using System.Threading.Tasks;
using System.IO;
using Glenshield.Cryptography;

namespace Glenshield.Communication
{
    public class TCPSocketClient
    {

        private TcpClient tcpClient;
        public EventHandler<CommunicationMessage> RaiseTextReceivedEvent;
        public EventHandler<CommunicationMessage> RaiseServerDisconnectedEvent;
        public EventHandler<CommunicationMessage> RaiseServerConnectedEvent;

        protected virtual void OnRaiseTextReceivedEvent(CommunicationMessage clientEventArguments)
        {
            RaiseTextReceivedEvent?.Invoke(this, clientEventArguments);
        }

        protected virtual void OnRaisePeerDisconnectedEvent(CommunicationMessage clientEventArguments)
        {
            RaiseServerDisconnectedEvent?.Invoke(this, clientEventArguments);
        }

        protected virtual void OnRaisePeerConnectedEvent(CommunicationMessage clientEventArguments)
        {
            RaiseServerConnectedEvent?.Invoke(this, clientEventArguments);
        }

        public async Task ConnectToServer()
        {
            if (tcpClient == null)
            {
                tcpClient = new TcpClient();
            }

            try
            {
                await tcpClient.ConnectAsync(IPAddress.Parse(Common.ServerIP), Common.SeverListeningOnPort);
                RaiseServerConnectedEvent(this, new CommunicationMessage(null, Common.CommunicationEventType.Connected));
                ReadMessageFromServerAsync(tcpClient);
            }
            catch (Exception excp)
            {
                Console.WriteLine(excp.ToString());
                throw;
            }
        }

        public void CloseAndDisconnect()
        {
            if (tcpClient != null)
            {
                if (tcpClient.Connected)
                {
                    tcpClient.Close();
                }
            }
        }

        public async Task SendMessageToServerAsync(string messageToSend)
        {
            if (string.IsNullOrEmpty(messageToSend))
            {
                return;
            }

            if (tcpClient != null)
            {
                if (tcpClient.Connected)
                {
                    StreamWriter clientStreamWriter = new StreamWriter(tcpClient.GetStream(), System.Text.Encoding.Unicode);
                    clientStreamWriter.AutoFlush = true;
                    await clientStreamWriter.WriteAsync(CryptographyService.EncryptForNetwork(messageToSend));
                }
            }
        }

        private async Task ReadMessageFromServerAsync(TcpClient mClient)
        {
            try
            {
                StreamReader clientStreamReader = new StreamReader(mClient.GetStream(),System.Text.Encoding.Unicode);

                char[] readMessageBuffer = new char[Common.ReadBufferSize];
                string readTextFromServer;
                int readByteCount = 0;

                while (true)
                {
                    try
                    {
                        readByteCount = await clientStreamReader.ReadAsync(readMessageBuffer, 0, readMessageBuffer.Length);

                        if (readByteCount <= 0)
                        {
                            OnRaisePeerDisconnectedEvent(new CommunicationMessage(null, Common.CommunicationEventType.Disconnected));
                            mClient.Close();
                            break;
                        }

                        readTextFromServer = new string(readMessageBuffer).Substring(0, readByteCount);
                        OnRaiseTextReceivedEvent(new CommunicationMessage(CryptographyService.DecryptFromNetwork(readTextFromServer), Common.CommunicationEventType.TextReceived));

                    }
                    catch
                    {

                    }
                    finally
                    {
                        Array.Clear(readMessageBuffer, 0, readMessageBuffer.Length);
                        readTextFromServer = "";
                    }
                }
            }
            catch
            {

            }

            
        }
    }
}
