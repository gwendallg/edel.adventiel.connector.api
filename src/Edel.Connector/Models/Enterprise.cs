using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Models
{
    [BsonIgnoreExtraElements]
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Enterprise
    {
        public Registration Registration { get; set; }
    }
}