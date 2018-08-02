using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Models.Cattles.EmbryoTransplantations
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "cattleEmbryoCollect")]
    [Resource(Name = "cattle-embryo-transplantation")]
    public class CattleBreederEmbryoTransplantation : CattleBreederEvent
    {
        public TeamCollectOrTransfert TransfertTeam { get; set; }
        public string CollectNumberDocument { get; set; }
        public CattleEmbryoSetup EmbryoSetup { get; set; }
        public string EmbryoSex { get; set; }
        public string EmbryoAge { get; set; }
        public string TransfertNumberDocument { get; set; }
    }
}