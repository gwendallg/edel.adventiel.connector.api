using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Api.Models.Bovines.EmbryoTransplantations
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "bovineEmbryoTransfert")]
    [Resource]
    public class BovineEmbryoTransfert : BovineEvent
    {
        public BovineTeamCollectOrTransfert TransfertBovineTeam { get; set; }
        public string CollectNumberDocument { get; set; }
        public BovineEmbryoSetup EmbryoSetup { get; set; }
        public string EmbryoSex { get; set; }
        public string EmbryoAge { get; set; }
        public string TransfertNumberDocument { get; set; }
    }
}