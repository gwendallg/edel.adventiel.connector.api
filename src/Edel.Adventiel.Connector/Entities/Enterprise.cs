using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Entities
{
    [BsonIgnoreExtraElements]
    public class Enterprise
    {
        public Registration Registration { get; set; }
    }
}