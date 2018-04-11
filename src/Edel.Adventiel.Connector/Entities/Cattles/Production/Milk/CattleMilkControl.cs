using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Entities.Cattles.Production.Milk
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "cattleMilkControl")]
    [Entity(Name = "cattle-milk-control")]
    public class CattleMilkControl : AbstractBreederData
    {
        public int? NumberTreatsPassage { get; set; }
        public bool? PresenceRobotTreats { get; set; }
    }
}