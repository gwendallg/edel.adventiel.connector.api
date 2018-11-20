using Edel.Connector.Models;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Api.Models.Bovines.EmbryoTransplantations
{
    [BsonIgnoreExtraElements]
    public class BovineTeamCollectOrTransfert
    {
        public Registration Registration { get; set; }
        public string Name { get; set; }
    }
}