using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;

namespace Edel.Connector.Api.Models
{
    [BsonIgnoreExtraElements]
    public class Claim
    {
        public string ResourcePath { get; set; }
        [BsonIgnore] 
        [JsonIgnore]
        public Type ResourceType { get; set; }
        [BsonRepresentation(BsonType.String)]
        public List<ScopeType> Scopes { get; set; }
    }
}