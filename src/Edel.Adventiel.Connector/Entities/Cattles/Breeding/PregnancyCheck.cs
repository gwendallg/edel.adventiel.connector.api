using System;
using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Entities.Cattles.Breeding
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "cattlePregnancyCheck")]
    [Entity(Name = "cattle-pregnancy-check", Insertable = false, Updatable = false, Deletable = false)]
    public class PregnancyCheck : AbstractCattleData
    {
        [Required]
        public DateTime PregnancyCheckDate { get; set; }
        
        public string PregnancyCheckType { get; set; }
        
        public string PregnancyCheckResultType { get; set; }
    }
}