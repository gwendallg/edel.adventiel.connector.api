using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Api.Models
{
    [BsonIgnoreExtraElements]
    public class Metadata
    {
        public DateTime CreatedDate { get; set; }
        
        public DateTime? LastModifiedDate { get; set; }
        
        public string CreatedAt { get; set; }
        
        public string LastModifiedAt { get; set; }
        
    }
}