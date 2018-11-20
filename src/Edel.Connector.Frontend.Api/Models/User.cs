using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Api.Models
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
        [BsonId]
        [EmailAddress]
        public string Username { get; set; }
        public string Salt { get; set; }
        public string Hash { get; set; }
        public IList<Claim> Claims { get; set; }
        public bool IsActive { get; set; }
    }
}