using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Entities.Cattles.Breeding
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "cattleCalvingCondition")]
    [Entity(Name = "cattle-calving-condition")]
    // ReSharper disable once ClassNeverInstantiated.Global
    public class CalvingCondition : ReferenceEntity
    {
    }
}