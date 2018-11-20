using Autumn.Mvc.Data.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Api.Models
{
    public abstract class Entity : Metadataeable, IEntity
    {
        [Id] [BsonId] [Ignore] public string Id { get; set; }
    }
}