using Autumn.Mvc.Data.Annotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Api.Models
{
   
    public abstract class AbstractElementModel<T>
        where T : MetadataModel
    {
        [Id]
        [BsonId]
        [Ignore]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        [Ignore]
        public T Metadata { get; set; }
    }
}