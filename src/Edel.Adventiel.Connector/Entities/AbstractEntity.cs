using Autumn.Mvc.Data.Annotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Entities
{
   
    public abstract class AbstractEntity<T>
        where T : Metadata
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