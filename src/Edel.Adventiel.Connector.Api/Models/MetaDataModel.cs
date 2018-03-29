using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Api.Models
{
    [BsonIgnoreExtraElements]
    public class MetadataModel
    {
        public DateTime CreatedDate { get; set; }
        
        public DateTime? LastModifiedDate { get; set; }
        
        public string CreatedAt { get; set; }
        
        public string LastModifiedAt { get; set; }
        
    }
}