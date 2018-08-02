using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Models.Cattles.Breeding
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "cattlePregnancyCheckType")]
    [Resource(Name = "cattle-pregnancy-check-type")]
    public class CattlePregnancyCheckType : ReferenceEntity
    {
    }
}