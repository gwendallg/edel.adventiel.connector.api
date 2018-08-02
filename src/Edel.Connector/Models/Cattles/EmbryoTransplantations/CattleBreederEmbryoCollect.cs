using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Models.Cattles.EmbryoTransplantations
{

    [BsonIgnoreExtraElements]
    [Collection(Name = "cattleEmbryoCollect")]
    [Resource(Name = "cattle-embryo-collect")]
    public class CattleBreederEmbryoCollect : CattleBreederEvent
    {
        public TeamCollectOrTransfert CollectTeam { get; set; }
        [Required] public int CollectNumber { get; set; }
        [Required] public string CollectType { get; set; }
        [Required] public string CollectNumberDocument { get; set; }
    }
}