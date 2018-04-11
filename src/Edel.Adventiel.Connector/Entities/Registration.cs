using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Entities
{
    [BsonIgnoreExtraElements]
    public class Registration
    {
        public string Identifier { get; set;} 
        public string IdentifierType { get; set; }
    }
}