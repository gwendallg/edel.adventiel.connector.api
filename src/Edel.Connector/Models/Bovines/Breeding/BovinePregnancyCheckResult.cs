using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Models.Bovines.Breeding
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "bovinePregnancyCheckResult")]
    [Resource]
    public class BovinePregnancyCheckResult : ReferenceEntity
    {
    }
}