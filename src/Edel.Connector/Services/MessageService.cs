using System.Collections.Generic;
using System.Linq;
using System.Net;
using Microsoft.Extensions.Configuration;

namespace Edel.Connector.Services
{
    public class MessageService : IMessageService
    {
        private readonly IConfiguration _configuration;

        public MessageService(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        
        public Dictionary<string, object> GetConfiguration()
        {
            var bootstrapServers = $"{_configuration["Kafka:BootstrapServers"]}";
            return new Dictionary<string, object>()
            {
                ["bootstrap.servers"] = bootstrapServers,
                ["retries"] = 0,
                ["client.id"] = BuildClientId(),
                ["batch.num.messages"] = 1,
                ["socket.blocking.max.ms"] = 1,
                ["socket.nagle.disable"] = true,
                ["queue.buffering.max.ms"] = 0,
                ["default.topic.config"] = new Dictionary<string, object>
                {
                    ["acks"] = 1,
                    ["message.timeout.ms"] = 2000,
                    ["request.timeout.ms"] = 2000
                },
                ["message.send.max.retries"] = 0
            };
        }

        public string GetRefreshDataRequestTopic()
        {
            return $"{_configuration["Kafka:Topic"]}";
        }
        
        private static  string BuildClientId()
        {
            var hostName = Dns.GetHostName();
            var ips = Dns.GetHostEntry(hostName)
                .AddressList
                .Select(a => a.ToString() + ",")
                .Aggregate(string.Concat).TrimEnd(',');

            return $"{hostName} ({ips})";
        }

    }
}