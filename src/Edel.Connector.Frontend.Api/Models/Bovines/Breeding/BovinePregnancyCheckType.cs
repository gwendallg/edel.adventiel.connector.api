﻿using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Api.Models.Bovines.Breeding
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "bovinePregnancyCheckType")]
    [Resource]
    public class BovinePregnancyCheckType : ReferenceEntity
    {
    }
}