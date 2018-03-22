using Edel.Adventiel.Connector.Api.Models.V1;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Api.Models
{
    public abstract class AbstractElementModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        public MetaDataModel Metadata { get; set; }
    }
}