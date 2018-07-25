using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Entities.Cattles.Production.Milk
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "cattleMilkControl")]
    [Entity(Name = "cattle-milk-control")]
    public class CattleMilkControl : BreederEntity
    {
        public int? NumberTreatsPassage { get; set; }
        public bool? PresenceRobotTreats { get; set; }
    }
}