using System;
using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Entities.Cattles.Production.Milk
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "cattleLactation")]
    [Entity(Name = "cattle-lactation")]
    public class CattleBreederLactation : AbstractCattleBreederEvent
    {
        [Required] public int LactationNumber { get; set; }

        public DateTime StartingDate { get; set; }

        public string LactationState { get; set; }

        public decimal TotalMilkLactation { get; set; }
    }
}