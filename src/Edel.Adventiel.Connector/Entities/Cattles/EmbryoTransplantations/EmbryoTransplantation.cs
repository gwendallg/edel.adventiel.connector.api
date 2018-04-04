using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Entities.Cattles.EmbryoTransplantations
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "cattleEmbryoCollect")]
    [Entity(Name = "cattle-embryo-transplantation", Insertable = false, Updatable = false, Deletable = false)]
    public class EmbryoTransplantation : AbstractCattleData
    {
        
    }
}