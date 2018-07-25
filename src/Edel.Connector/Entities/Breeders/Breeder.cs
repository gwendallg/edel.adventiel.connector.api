using Autumn.Mvc.Data.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Entities.Breeders
{
    [BsonIgnoreExtraElements]
    [Entity(Name = "breeder")]
    public class Breeder : BreederEntity
    {
    }
}