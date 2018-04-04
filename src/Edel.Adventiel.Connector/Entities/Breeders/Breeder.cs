using System;
using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using Edel.Adventiel.Connector.Entities;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Entities.Breeders
{
    [BsonIgnoreExtraElements]
    [Entity(Name = "breeder", Insertable = false, Updatable = false, Deletable = false)]
    public class Breeder : AbstractBreederData
    {
    }
}