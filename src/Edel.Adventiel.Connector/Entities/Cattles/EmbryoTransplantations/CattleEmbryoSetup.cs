using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Entities.Cattles.EmbryoTransplantations
{
    [BsonIgnoreExtraElements]
    public class CattleEmbryoSetup
    {
        public CattleInfo FemaleDonor { get; set; }
        public CattleInfo PossibleFather { get; set; }
    }
}