using System;
using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Models.Cattles.Breeding
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "cattleCalving")]
    [Resource(Name = "cattle-calving")]
    public class Calving : CattleBreederEvent
    {
        public string CalvingCondition{ get; set; }
        
        public int? CalvinRank { get; set; }
        
        public bool? CalvingMultiple { get; set; }
    }
}