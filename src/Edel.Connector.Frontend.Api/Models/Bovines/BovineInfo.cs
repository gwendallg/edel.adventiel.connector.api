using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Api.Models.Bovines
{
    [BsonIgnoreExtraElements]
    public class BovineInfo
    {
        public BovineIdentity Identity { get; set; }
        
        /// <summary>
        /// cattle identifier
        /// </summary>
        [Required] public string BovineIdentifier { get; set; }

        /// <summary>
        /// catte country code
        /// </summary>
        [Required] public string BovineCountryCode { get; set; }
    }
}