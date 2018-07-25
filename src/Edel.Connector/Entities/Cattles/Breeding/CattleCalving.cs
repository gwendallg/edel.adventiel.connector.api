using System;
using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Entities.Cattles.Breeding
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "cattleCalving")]
    [Entity(Name = "cattle-calving")]
    public class Calving : CattleBreederEvent
    {
        public string CalvingCondition{ get; set; }
        
        public int? CalvinRank { get; set; }
        
        public bool? CalvingMultiple { get; set; }
    }
}