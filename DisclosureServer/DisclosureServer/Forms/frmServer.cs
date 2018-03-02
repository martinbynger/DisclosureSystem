using Glenshield.Communication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DisclosureServer
{
    public partial class frmServer : Form
    {
        private TCPSocketServer tcpSocketServer;

        public frmServer()
        {
            InitializeComponent();
        }

        private void frmServer_Load(object sender, EventArgs e)
        {
            Infragistics.Win.AppStyling.StyleManager.Load("./Resources/IG.isl");

            tcpSocketServer = new TCPSocketServer();
            tcpSocketServer.RaiseClientConnectedEvent += HandleClientConnected;
            tcpSocketServer.RaiseTextReceivedEvent += HandleTextReceived;
            tcpSocketServer.RaiseClientDisconnectedEvent += HandleClientDisconnected;
            tcpSocketServer.RaiseClientAuthenticatedEvent += HandleClientAuthenticated;
            tcpSocketServer.StartListeningForIncomingConnection();

        }

        private void HandleClientConnected(object sender, CommunicationMessage e)
        {
            Infragistics.Win.UltraWinTree.UltraTreeNode unauthenticatedClientNodeParent = trvConnectedClients.Nodes[0];
            Infragistics.Win.UltraWinTree.UltraTreeNode unauthenticatedClientNode = new Infragistics.Win.UltraWinTree.UltraTreeNode(e.UserID + " on " + e.SenderID);
            unauthenticatedClientNodeParent.Nodes.Add(unauthenticatedClientNode);

        }

        private void HandleClientAuthenticated(object sender, CommunicationMessage e)
        {
            Infragistics.Win.UltraWinTree.UltraTreeNode UnauthenticatedClientNode = trvConnectedClients.GetNodeByKey(e.UserID + " on " + e.SenderID);
            UnauthenticatedClientNode.Remove();

            Infragistics.Win.UltraWinTree.UltraTreeNode authenticatedClientNodeParent = trvConnectedClients.Nodes[1];
            Infragistics.Win.UltraWinTree.UltraTreeNode authenticatedClientNode = new Infragistics.Win.UltraWinTree.UltraTreeNode(e.UserID + " on " + e.SenderID);
            authenticatedClientNodeParent.Nodes.Add(authenticatedClientNode);

        }

        private void HandleTextReceived(object sender, CommunicationMessage e)
        {
            AddMessageOutput(e.AllText);
            tcpSocketServer.SendToAuthenticatedClient(clsMessageProcessing.ProcessReceivedMessage(e));
        }

        private void HandleClientDisconnected(object sender, CommunicationMessage e)
        {
            Infragistics.Win.UltraWinTree.UltraTreeNode UnauthenticatedClientNode = trvConnectedClients.GetNodeByKey(e.UserID + " on " + e.SenderID);
            UnauthenticatedClientNode.Remove();
        }

        private void AddMessageOutput(string messageText)
        {
            AddMessageToQueue(txtMessages, messageText);
        }

        private void ReportError(string messageText)
        {
            AddMessageToQueue(txtErrors, messageText);
        }

        private void AddMessageToQueue(Infragistics.Win.UltraWinEditors.UltraTextEditor ultraTextEditor, string messageText)
        {
            if (ultraTextEditor.Text.Length > 10000)
            {
                ultraTextEditor.Text = ("\r\n" + messageText + "\r\n" + ultraTextEditor.Text).ToString().Substring(0, 10000);
            }
            else
            {
                ultraTextEditor.Text = "\r\n" + messageText + "\r\n" + ultraTextEditor.Text;
            }

        }

    }
}
