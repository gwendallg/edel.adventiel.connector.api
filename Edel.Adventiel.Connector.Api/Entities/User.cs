using System.Collections.Generic;
using Edel.Adventiel.Connector.Api.Models.V1;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Api.Entities
{
    public class User
    {
        [BsonId]
        public string Username { get; set; }
        public string Salt { get; set; }
        public string Hash { get; set; }
        public Dictionary<string,string> Claims { get; set; }
        public MetaDataModel Metadata { get; set; }
    }
}