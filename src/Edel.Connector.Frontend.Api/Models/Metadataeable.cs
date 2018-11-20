using Autumn.Mvc.Data.Annotations;

namespace Edel.Connector.Api.Models
{
    public abstract class Metadataeable : IMetadataeable
    {
        [Ignore] public Metadata Metadata { get; set; }
    }
}