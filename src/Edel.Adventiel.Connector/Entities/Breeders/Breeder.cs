using System;
using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using Edel.Adventiel.Connector.Entities;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Entities.Breeders
{
    [BsonIgnoreExtraElements]
    [Entity(Name = "breeder", Deletable = false)]
    public class Breeder : AbstractEntity<MetadataWithOrigin>
    {
        [Required] public string BreederIdentifier { get; set; }

        [Required] public string BreederCountryCode { get; set; }

        [Ignore(Updatable = true)]
        public DateTime? LastImportDate { get; set; }
    }
}