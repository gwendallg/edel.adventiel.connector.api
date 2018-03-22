using System.ComponentModel.DataAnnotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Api.Models.V1.Cattles
{
    public abstract class AbstractCattleDataModel : AbstractElementModel
    {
        [Required]
        [BsonElement("cattle_identifier")]
        public string CattleIdentifier { get; set; }
        
        [Required]
        [BsonElement("cattle_country_code")]
        public string CattleCountryCode { get; set; }

        [Required]
        [BsonElement("breeder_identifier")]
        public string BreederIdentifier { get; set; }
        
        [Required]
        [BsonElement("breeder_country_code")]
        public string BreederCountryCode { get; set; }
        
        [BsonElement("identity")]
        public CattleIdentityModel Identity { get; set; }
    }
}