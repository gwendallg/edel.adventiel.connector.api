using Autumn.Mvc.Data.Annotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Entities
{
    public abstract class AbstractEntityWithId : AbstractEntity
    {
        [Id]
        [BsonId]
        [Ignore]
        public virtual string Id { get; set; }
        

    }
}