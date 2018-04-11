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
    public class CattleInsemination : AbstractCattleBreederEvent
    {
        public CattleInseminator Inseminator { get; set; }
        public CattleBreedingBull BreedingBull { get; set; }
    }
}