using System;

namespace Glenshield.Communication
{
    public static class Common
    {
        public const string ServerIP = "127.0.0.1";
        public const int SeverListeningOnPort = 38165;
        public const int ClientDidDisconnect = 0;
        public const int ReadBufferSize = 10000000;
        public const string UnicodeIdentifierCharacter = "﻿";

        public enum CommunicationMessageType
        {
            None,
            Login
        };

        public enum CommunicationEventType
        {
            Connected,
            Disconnected,
            TextReceived,
            Created
        };

        public enum CommunicationClientType
        {
            None,
            TaximeterClient,
            Controller,
            ExceptionReporter
        };

        public enum CommunicationMessagePositions
        {
            MessageType,
            MessageID,
            SenderID,
            SenderAuthentication,
            SenderType,
            RecipientID,
            RecipientType,
            UserID,
            UserAuthentication,
            MessageData
        }

        public struct CommunicationAuthenticationData
        {
            public int ID;
            public string Authentication;
            public CommunicationClientType Type;
        }
    }
}
