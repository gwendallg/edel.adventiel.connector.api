namespace Edel.Adventiel.Connector.Entities
{
    public class MetadataWithOrigin : Metadata
    {
        public string Origin { get; set; }
        public string OriginExternalId { get; set; }
        public string OriginVersion { get; set; }
    }
}