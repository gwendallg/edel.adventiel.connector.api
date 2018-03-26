using System;
using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Api.Models.V1.Breeders
{
    [BsonIgnoreExtraElements]
    [Entity(Name = "breeder", Deletable = false)]
    public class BreederModel : AbstractElementModel
    {
        [Required] public string BreederIdentifier { get; set; }

        [Required] public string BreederCountryCode { get; set; }

        public DateTime? LastImportDate { get; set; }
    }
}