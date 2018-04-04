using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Entities.Cattles.EmbryoTransplantations
{

    [BsonIgnoreExtraElements]
    [Collection(Name = "cattleEmbryoCollect")]
    [Entity(Name = "cattle-embryo-collect", Insertable = false, Updatable = false, Deletable = false)]
    public class EmbryoCollect : AbstractCattleData
    {
        public string CollectTeam { get; set; }
        public int CollectNumber { get; set; }
        public string CollectType { get; set; }
        public string CollectNumberDocument { get; set; }
    }
}