using System;
using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Api.Models.V1.Cattles.Breeding
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "cattleInsemination")]
    [Entity(Name = "cattle-insemination")]
    public class InseminationModel : AbstractCattleDataModel
    {
        [Required]
        public DateTime InseminationDate { get; set; }
        
    }
}