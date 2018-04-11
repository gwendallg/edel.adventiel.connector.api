using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Entities.Cattles.EmbryoTransplantations
{

    [BsonIgnoreExtraElements]
    [Collection(Name = "cattleEmbryoCollect")]
    [Entity(Name = "cattle-embryo-collect")]
    public class CattleBreederEmbryoCollect : AbstractCattleBreederEvent
    {
        public TeamCollectOrTransfert CollectTeam { get; set; }
        [Required] public int CollectNumber { get; set; }
        [Required] public string CollectType { get; set; }
        [Required] public string CollectNumberDocument { get; set; }
    }
}