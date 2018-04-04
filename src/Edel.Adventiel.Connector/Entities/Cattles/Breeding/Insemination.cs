using System;
using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Entities.Cattles.Breeding
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "cattleInsemination")]
    [Entity(Name = "cattle-insemination")]
    public class Insemination : AbstractCattleData
    {
        [Required]
        public DateTime InseminationDate { get; set; }
        
    }
}