using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Entities.Users
{
    public class User
    {
        [BsonId]
        public string Username { get; set; }
        public string Salt { get; set; }
        public string Hash { get; set; }
        public Dictionary<string,string> Claims { get; set; }
        public Metadata Metadata { get; set; }
    }
}