using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Entities.Cattles.EmbryoTransplantations
{
    [BsonIgnoreExtraElements]
    public class TeamCollectOrTransfert
    {
        public Registration Registration { get; set; }
        public string Name { get; set; }
    }
}