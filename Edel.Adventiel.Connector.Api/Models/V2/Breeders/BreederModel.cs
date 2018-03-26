using Autumn.Mvc.Data.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Api.Models.V2.Breeders
{
    [BsonIgnoreExtraElements]
    [Entity(Name = "breeder", Deletable = false, Version = "v2")]
    public class BreederModel : V1.Breeders.BreederModel
    {
        public string Name { get; set; }
    }
}