using System;
using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Api.Models.V1.Cattles.Breeding
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "cattleAbortion")]
    [Entity(Name = "cattle/abortion")]
    public class AbortionModel : AbstractCattleDataModel
    {
        [Required]
        public DateTime AbortionDate { get; set; }
        public int? EndPregnancyRank { get; set; }
    }
}