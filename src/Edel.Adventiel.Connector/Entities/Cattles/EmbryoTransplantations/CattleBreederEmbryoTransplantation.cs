using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Entities.Cattles.EmbryoTransplantations
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "cattleEmbryoCollect")]
    [Entity(Name = "cattle-embryo-transplantation")]
    public class CattleBreederEmbryoTransplantation : AbstractCattleBreederEvent
    {
        public TeamCollectOrTransfert TransfertTeam { get; set; }
        public string CollectNumberDocument { get; set; }
        public CattleEmbryoSetup EmbryoSetup { get; set; }
        public string EmbryoSex { get; set; }
        public string EmbryoAge { get; set; }
        public string TransfertNumberDocument { get; set; }
    }
}