using System;
using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Models.Cattles.Production.Milk
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "cattleMastitis")]
    [Resource(Name = "cattle-mastitis")]
    public class CattleBreederMastitis : CattleBreederEvent
    {
        public string CollectOriginCode { get; set; }
        public string MastitisSeverity { get; set; }
        [Required]
        public DateTime CollectMastitisDate { get; set; }
    }
}