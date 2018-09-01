using System;
using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Models.Bovines.Breeding
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "bovineAbortion")]
    [Resource]
    public class BovineAbortion : BovineEvent
    {
        public int? EndPregnancyRank { get; set; }
    }
}