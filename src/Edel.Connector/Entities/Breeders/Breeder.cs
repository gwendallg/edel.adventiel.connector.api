﻿using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Entities.Breeders
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "breeder")]
    [Resource(Name = "breeder")]
    public class Breeder : BreederEntity
    {
    }
}