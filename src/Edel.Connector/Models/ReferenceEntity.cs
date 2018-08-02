using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Models
{
    public abstract class ReferenceEntity : Metadataeable, IEntity
    {
        [Required] public string Label { get; set; }
        [Id] [BsonId] [Ignore] public string Id { get; set; }
    }
}