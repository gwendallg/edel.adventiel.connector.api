using System.Collections.Generic;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Models
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "user")]
    [Entity]
    public class User : Metadataeable
    {
        /// <summary>
        /// user name 
        /// </summary>
        [Id]
        [BsonId] public string Username { get; set; }
        public string Salt { get; set; }
        public string Hash { get; set; }
        public Dictionary<string, string> Claims { get; set; }

    }
}