using System;
using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Api.Models.V1
{
    public class MetaDataModel
    {
        [BsonElement("created_date")]
        [Required]
        public DateTime CreatedDate { get; set; }
        
        [BsonElement("last_modified_date")]
        public DateTime? LastModifiedDate { get; set; }
        
        [BsonElement("created_at")]
        [Required]
        public string CreatedAt { get; set; }
        
        [BsonElement("last_modified_at")]
        public string LastModifiedAt { get; set; }
        
        [BsonElement("is_deleted")]
        public bool IsDeleted { get; set; }
    }
}