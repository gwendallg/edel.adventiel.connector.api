using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Models.Cattles
{
    [BsonIgnoreExtraElements]
    [Resource(Name = "cattle")]
    // ReSharper disable once ClassNeverInstantiated.Global
    public class CattleBreeder : BreederEntity
    {
        /// <summary>
        /// cattle identifier
        /// </summary>
        [Required] public string CattleIdentifier { get; set; }

        /// <summary>
        /// catte country code
        /// </summary>
        [Required] public string CattleCountryCode { get; set; }
        
        public CattleIdentity Identity { get; set; }
    }
}