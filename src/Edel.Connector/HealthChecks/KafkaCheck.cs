using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Confluent.Kafka;
using Edel.Connector.Messages;
using Microsoft.Extensions.HealthChecks;

namespace Edel.Connector.HealthChecks
{
    public class KafkaCheck :IHealthCheck
    {
        private readonly Dictionary<string, object> _configuration;
        private const string Topic = "breeder-data-refresh";

        public KafkaCheck(string bootstrapServers, string clientId)
        {
            _configuration = new Dictionary<string, object>()
            {
                ["bootstrap.servers"] = bootstrapServers,
                ["retries"] = 0,
                ["client.id"] = clientId,
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

        public async ValueTask<IHealthCheckResult> CheckAsync(
            CancellationToken cancellationToken = new CancellationToken())
        {
            try
            {
                using (var producer =
                    new Producer<Null, BreederDataRefreshMessage>(_configuration, null,
                        new BreederDataRefershMessageSerializer()))
                {
                    var message = new BreederDataRefreshMessage() {IsHealthCheck = true};
                    var result = await producer.ProduceAsync(Topic, null, message);
                    if (result.Error.HasError)
                    {
                        throw new Exception(result.Error.Reason);
                    }

                    return HealthCheckResult.Healthy($"Successfully send message to Kafka Message Broker.");
                }
            }
            catch
            {
                return HealthCheckResult.Unhealthy($"Failed to connect to Kafka Message Broker.");
            }
        }
    }
}