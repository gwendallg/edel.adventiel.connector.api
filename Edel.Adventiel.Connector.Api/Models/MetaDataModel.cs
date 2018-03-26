using System;
using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Api.Models.V1
{
    public class MetaDataModel
    {
        [Required]
        [CreatedDate]
        public DateTime CreatedDate { get; set; }
        
        [LastModifiedDate]
        public DateTime? LastModifiedDate { get; set; }
        
        [Required]
        [CreatedBy]
        public string CreatedAt { get; set; }
        
        [LastModifiedBy]
        public string LastModifiedAt { get; set; }
        
        public bool IsDeleted { get; set; }
    }
}