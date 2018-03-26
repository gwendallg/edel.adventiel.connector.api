using System;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Api.Models.V1.Cattles.Breeding
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "cattleCalving")]
    [Entity(Name = "cattle/calving")]
    public class CalvingModel : AbstractCattleDataModel
    {
        [Required]
        public DateTime CalvingDate { get; set; }
        
        public string CalvingCondition { get; set; }
        
        public int? CalvinRank { get; set; }
        
        public bool? CalvingMultiple { get; set; }
    }
}