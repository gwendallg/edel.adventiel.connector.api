using System;
using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Entities.Cattles.Breeding
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "cattleAbortion")]
    [Entity(Name = "cattle-abortion")]
    public class CattleAbortion : CattleBreederEvent
    {
        public int? EndPregnancyRank { get; set; }
    }
}