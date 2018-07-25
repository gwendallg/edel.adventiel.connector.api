using Autumn.Mvc.Data.Annotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Entities
{
    public abstract class Entity : Metadataeable, IEntity
    {
        [Id] [BsonId] [Ignore] public string Id { get; set; }
    }
}