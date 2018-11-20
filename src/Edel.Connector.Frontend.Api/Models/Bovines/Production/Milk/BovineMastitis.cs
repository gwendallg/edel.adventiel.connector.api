using System;
using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Api.Models.Bovines.Production.Milk
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "bovineMastitis")]
    [Resource]
    public class BovineMastitis : BovineEvent
    {
        public string CollectOriginCode { get; set; }
        public string MastitisSeverity { get; set; }
        [Required]
        public DateTime CollectMastitisDate { get; set; }
    }
}