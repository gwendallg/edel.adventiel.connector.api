using Autumn.Mvc.Data.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Entities.Cattles
{
    [BsonIgnoreExtraElements]
    [Resource(Name = "cattle")]
    // ReSharper disable once ClassNeverInstantiated.Global
    public class CattleBreeder : CattleBreederEvent
    {
        public CattleIdentity Identity { get; set; }
    }
}