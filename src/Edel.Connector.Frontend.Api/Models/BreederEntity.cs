using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Api.Models
{
    public abstract class BreederEntity : Metadataeable, IEntity
    {
        /// <summary>
        /// data unique ID
        /// </summary>
        [Id]
        [BsonId]
        [Ignore]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        [Required]
        public string TenantId {get; set; }

        /// <summary>
        /// breeder ID
        /// </summary>
        [Required]
        public string BreederIdentifier { get; set; }

        /// <summary>
        /// breeder country code
        /// </summary>
        [Required]
        public string BreederCountryCode { get; set; }
        
        /// <summary>
        /// data is obsolete
        /// </summary>
        [Required]
        public bool IsObsolete { get; set; }
    }
}