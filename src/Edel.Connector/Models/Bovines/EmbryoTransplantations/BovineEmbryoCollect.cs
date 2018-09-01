using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Models.Bovines.EmbryoTransplantations
{

    [BsonIgnoreExtraElements]
    [Collection(Name = "bovineEmbryoCollect")]
    [Resource]
    public class BovineEmbryoCollect : BovineEvent
    {
        public BovineTeamCollectOrTransfert CollectBovineTeam { get; set; }
        [Required] public int CollectNumber { get; set; }
        [Required] public string CollectType { get; set; }
        [Required] public string CollectNumberDocument { get; set; }
    }
}