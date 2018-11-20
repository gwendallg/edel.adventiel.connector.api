using System;
using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Api.Models.Bovines.Production.Milk
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "bovineLactation")]
    [Resource]
    public class BovineLactation : BovineEvent
    {
        [Required] public int LactationNumber { get; set; }

        public DateTime StartingDate { get; set; }

        public string LactationState { get; set; }

        public decimal TotalMilkLactation { get; set; }
    }
}