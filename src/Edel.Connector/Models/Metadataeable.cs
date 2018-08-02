using Autumn.Mvc.Data.Annotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Models
{
    public abstract class Metadataeable : IMetadataeable
    {
        [Ignore] public Metadata Metadata { get; set; }
    }
}