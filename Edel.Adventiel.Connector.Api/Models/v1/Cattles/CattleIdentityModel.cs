using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Api.Models.V1.Cattles
{
    public class CattleIdentityModel
    {
        [BsonElement("name")]
        public string Name { get; set; }

        [BsonElement("breed_code")]
        public string BreedCode { get; set; }
        
        [BsonElement("birth_date")]
        public DateTime? BirthDate { get; set; }
        
        [BsonElement("sex")]
        public string Sex { get; set; }
    }
}