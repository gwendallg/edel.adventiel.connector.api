using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Api.Models.V1.Cattles.Breeding
{
    public class PregnancyCheckModel : AbstractCattleDataModel
    {
        [Required]
        [BsonElement("pregnancy_check_date")]
        public DateTime PregnancyCheckDate { get; set; }
    }
}