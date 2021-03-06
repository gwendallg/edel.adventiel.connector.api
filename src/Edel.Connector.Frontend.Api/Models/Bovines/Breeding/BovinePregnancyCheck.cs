﻿using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Api.Models.Bovines.Breeding
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "bovinePregnancyCheck")]
    [Resource]
    public class BovinePregnancyCheck : BovineEvent
    {
        public string PregnancyCheckType { get; set; }
        public string PregnancyCheckResult { get; set; }
    }
}