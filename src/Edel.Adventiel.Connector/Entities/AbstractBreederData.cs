using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Entities
{
    public  abstract class AbstractBreederData  : AbstractEntityWithId
    {
        /// <summary>
        /// Id of entity
        /// </summary>
        [Id]
        [BsonId]
        [Ignore]
        [BsonRepresentation(BsonType.ObjectId)]
        public new string Id { get; set; }
        
        /// <summary>
        /// breeder identifier
        /// </summary>
        [Required] public string BreederIdentifier { get; set; }

        /// <summary>
        /// breeder country code
        /// </summary>
        [Required] public string BreederCountryCode { get; set; }
    }
}