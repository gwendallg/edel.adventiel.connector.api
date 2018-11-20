using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Api.Models
{
    [BsonIgnoreExtraElements]
    public class Registration
    {
        public string Identifier { get; set;} 
        public string IdentifierType { get; set; }
    }
}