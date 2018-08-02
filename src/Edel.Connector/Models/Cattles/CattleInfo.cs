using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Models.Cattles
{
    [BsonIgnoreExtraElements]
    public class CattleInfo
    {
        public CattleIdentity Identity { get; set; }
        
        /// <summary>
        /// cattle identifier
        /// </summary>
        [Required] public string CattleIdentifier { get; set; }

        /// <summary>
        /// catte country code
        /// </summary>
        [Required] public string CattleCountryCode { get; set; }
    }
}