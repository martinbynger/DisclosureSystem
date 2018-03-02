using System;
using System.Text;
namespace Glenshield.Communication
{

    public class CommunicationMessage : EventArgs
    {
        #region "Private variables"

        private string allText;
        private int messageType = (int)Common.CommunicationMessageType.None;
        private int messageID = 0;
        private string senderID = "";
        private string senderAuthentication="";
        private int senderType = 0;
        private string recipientID = "";
        private int recipientType = (int)Common.CommunicationClientType.None;
        private string userID = "";
        private string userAuthentication = "";
        private string messageData = "";

        #endregion

        #region "Constructors"

        public CommunicationMessage(string AllTextFromClient, Common.CommunicationEventType theEventType)
        {
            AllText = AllTextFromClient;

            try
            {
                if (theEventType == Common.CommunicationEventType.TextReceived)
                {
                    string[] MessageReaderBuffer = AllTextFromClient.Split('#');
                    MessageType = int.Parse(MessageReaderBuffer[(int)Common.CommunicationMessagePositions.MessageType]);
                    MessageID = int.Parse(MessageReaderBuffer[(int)Common.CommunicationMessagePositions.MessageID]);
                    SenderID = MessageReaderBuffer[(int)Common.CommunicationMessagePositions.SenderID];
                    SenderAuthentication = MessageReaderBuffer[(int)Common.CommunicationMessagePositions.SenderAuthentication];
                    SenderType = int.Parse(MessageReaderBuffer[(int)Common.CommunicationMessagePositions.SenderType]);
                    RecipientID = MessageReaderBuffer[(int)Common.CommunicationMessagePositions.RecipientID];
                    RecipientType = int.Parse(MessageReaderBuffer[(int)Common.CommunicationMessagePositions.RecipientType]);
                    UserID = MessageReaderBuffer[(int)Common.CommunicationMessagePositions.SenderType];
                    UserAuthentication = MessageReaderBuffer[(int)Common.CommunicationMessagePositions.SenderAuthentication];
                    MessageData = MessageReaderBuffer[(int)Common.CommunicationMessagePositions.MessageData];
                }
            }
            catch
            {

            }

        }
        public int MessageID
        {
            get
            {
                return messageID;
            }
            set
            {
                messageID = value;
            }
        }
        public int MessageType
        {
            get
            {
                return messageType;
            }
            set
            {
                messageType = value;
            }
        }
        public string SenderID
        {
            get
            {
                return senderID;
            }
            set
            {
                senderID = value;
            }
        }
        public string SenderAuthentication
        {
            get
            {
                return senderAuthentication;
            }
            set
            {
                senderAuthentication = value;
            }
        }
        public int SenderType
        {
            get
            {
                return senderType;
            }
            set
            {
                senderType = value;
            }
        }
        public string RecipientID
        {
            get
            {
                return recipientID;
            }
            set
            {
                recipientID = value;
            }
        }
        public int RecipientType
        {
            get
            {
                return recipientType;
            }
            set
            {
                recipientType = value;
            }
        }
        public string UserID
        {
            get
            {
                return userID;
            }
            set
            {
                userID = value;
            }
        }
        public string UserAuthentication
        {
            get
            {
                return userAuthentication;
            }
            set
            {
                userAuthentication = value;
            }
        }
        public string MessageData
        {
            get
            {
                return messageData;
            }
            set
            {
                messageData = value;
            }
        }
        public string AllText
        {
            get
            {
                return allText;
            }
            set
            {
                allText = value;
            }
        }

        #endregion

        #region "Methods"

        public string BuildCommunicationMessageText()
        {
            StringBuilder messageStringBuilder = new StringBuilder("");
            messageStringBuilder.Append(MessageType);
            messageStringBuilder.Append("#").Append(MessageID).Append("#").Append(SenderID);
            messageStringBuilder.Append("#").Append(SenderAuthentication).Append("#").Append(SenderType);
            messageStringBuilder.Append("#").Append(RecipientID).Append("#").Append(RecipientType);
            messageStringBuilder.Append("#").Append(UserID).Append("#").Append(UserAuthentication);
            messageStringBuilder.Append("#").Append(MessageData);

            return messageStringBuilder.ToString();

        }

        #endregion
    }
}
