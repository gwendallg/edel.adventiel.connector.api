using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Entities
{
    [BsonIgnoreExtraElements]
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Enterprise
    {
        public Registration Registration { get; set; }
    }
}