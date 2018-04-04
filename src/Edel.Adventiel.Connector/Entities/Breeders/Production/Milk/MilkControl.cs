using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Entities.Breeders.Production.Milk
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "breederMilkControl")]
    [Entity(Name = "breeder-milk-control", Insertable = false, Updatable = false, Deletable = false)]
    public class MilkControl : AbstractBreederData
    {
        public int? NumberTreatsPassage { get; set; }
        public bool? PresenceRobotTreats { get; set; }
    }
}