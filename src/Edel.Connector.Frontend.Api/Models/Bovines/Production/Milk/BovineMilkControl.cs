using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Api.Models.Bovines.Production.Milk
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "bovineMilkControl")]
    [Resource]
    public class BovineMilkControl : BreederEntity
    {
        public int? NumberTreatsPassage { get; set; }
        public bool? PresenceRobotTreats { get; set; }
    }
}