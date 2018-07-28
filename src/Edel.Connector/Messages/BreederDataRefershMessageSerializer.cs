using System.Collections.Generic;
using Confluent.Kafka.Serialization;
using Newtonsoft.Json;

namespace Edel.Connector.Messages
{
    public class BreederDataRefershMessageSerializer : ISerializer<BreederDataRefreshMessage>
    {
        public void Dispose()
        {
        }

        public byte[] Serialize(string topic, BreederDataRefreshMessage data)
        {
            var stringify = JsonConvert.SerializeObject(data);
            return System.Text.Encoding.UTF8.GetBytes(stringify);
        }

        public IEnumerable<KeyValuePair<string, object>> Configure(IEnumerable<KeyValuePair<string, object>> config, bool isKey)
        {
            return null;
        }
    }
}