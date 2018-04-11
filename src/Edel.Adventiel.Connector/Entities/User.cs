using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Entities
{
    [BsonIgnoreExtraElements]
    public class User : Metadataeable
    {
        /// <summary>
        /// user name 
        /// </summary>
        [BsonId] public string Username { get; set; }
        public string Salt { get; set; }
        public string Hash { get; set; }
        public Dictionary<string, string> Claims { get; set; }

    }
}