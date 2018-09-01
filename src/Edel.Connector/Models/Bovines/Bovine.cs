using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Models.Bovines
{
    [BsonIgnoreExtraElements]
    [Resource]
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Bovine : BreederEntity
    {
        /// <summary>
        /// bovine identifier
        /// </summary>
        [Required] public string BovineIdentifier { get; set; }

        /// <summary>
        /// bovine country code
        /// </summary>
        [Required] public string BovineCountryCode { get; set; }
        
        /// <summary>
        /// bovine identity
        /// </summary>
        public BovineIdentity Identity { get; set; }
    }
}