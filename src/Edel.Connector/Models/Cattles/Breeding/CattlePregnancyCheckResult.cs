using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Models.Cattles.Breeding
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "cattlePregnancyCheckResult")]
    [Resource(Name = "cattle-pregnancy-check-result")]
    public class CattlePregnancyCheckResult : ReferenceEntity
    {
    }
}