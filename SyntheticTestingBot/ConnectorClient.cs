using Microsoft.Bot.Connector;
using Microsoft.Bot.Schema;
using System;
using System.Threading.Tasks;

namespace SyntheticTestingBot
{
    public class ConnectorClient
    {
        private readonly ConnectorClient _connectorClient;
        public ConnectorClient(Uri serviceUri)
        {
            _connectorClient = new ConnectorClient(serviceUri);
        }

        public async Task<ResourceResponse> SendToConversationAsync(IMessageActivity activity)
        {
            return await _connectorClient.SendToConversationAsync(activity);
        }
    }
}
