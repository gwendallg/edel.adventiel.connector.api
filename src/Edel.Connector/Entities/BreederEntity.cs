using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Entities
{
    public abstract class BreederEntity : Metadataeable, IEntity
    {
        /// <summary>
        /// Id of entity
        /// </summary>
        [Id]
        [BsonId]
        [Ignore]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        /// <summary>
        /// breeder identifier
        /// </summary>
        [Required]
        public string BreederIdentifier { get; set; }

        /// <summary>
        /// breeder country code
        /// </summary>
        [Required]
        public string BreederCountryCode { get; set; }
    }
}