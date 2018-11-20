using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Api.Models.Bovines.EmbryoTransplantations
{
    [BsonIgnoreExtraElements]
    public class BovineEmbryoSetup
    {
        public BovineInfo FemaleDonor { get; set; }
        public BovineInfo PossibleFather { get; set; }
    }
}