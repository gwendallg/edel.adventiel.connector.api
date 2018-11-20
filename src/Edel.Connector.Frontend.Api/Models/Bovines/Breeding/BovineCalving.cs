using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Api.Models.Bovines.Breeding
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "bovineCalving")]
    [Resource]
    public class BovineCalving : BovineEvent
    {
        public string CalvingCondition{ get; set; }
        
        public int? CalvinRank { get; set; }
        
        public bool? CalvingMultiple { get; set; }
    }
}