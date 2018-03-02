using Glenshield.Communication;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisclosureServer
{
    static class clsMessageProcessing
    {

        public static CommunicationMessage ProcessReceivedMessage(CommunicationMessage communicationMessage)
        {
            return new CommunicationMessage("", Common.CommunicationEventType.Created);
        }

        public static bool CanAuthenticate(CommunicationMessage communicationMessage)
        {
            return true;
        }
    }
}
