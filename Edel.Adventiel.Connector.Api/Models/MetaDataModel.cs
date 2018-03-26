using System;
using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Api.Models.V1
{
    [BsonIgnoreExtraElements]
    public class MetaDataModel
    {
        public DateTime CreatedDate { get; set; }
        
        public DateTime? LastModifiedDate { get; set; }
        
        public string CreatedAt { get; set; }
        
        public string LastModifiedAt { get; set; }
        
    }
}