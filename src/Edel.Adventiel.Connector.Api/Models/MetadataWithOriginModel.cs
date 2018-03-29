using Edel.Adventiel.Connector.Api.Models;

namespace Edel.Adventiel.Connector.Api.Models
{
    public class MetadataWithOriginModel : MetadataModel
    {
        public string Origin { get; set; }
        public string OriginExternalId { get; set; }
        public string OriginVersion { get; set; }
    }
}