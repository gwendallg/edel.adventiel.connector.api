using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Entities.Cattles.Breeding
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "cattlePregnancyCheckType")]
    [Entity(Name = "cattle-pregnancy-check-type")]
    public class CattlePregnancyCheckType : ReferenceEntity
    {
    }
}