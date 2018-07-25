using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Entities.Cattles.Breeding
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "cattlePregnancyCheckResult")]
    [Entity(Name = "cattle-pregnancy-check-result")]
    public class CattlePregnancyCheckResult : ReferenceEntity
    {
    }
}