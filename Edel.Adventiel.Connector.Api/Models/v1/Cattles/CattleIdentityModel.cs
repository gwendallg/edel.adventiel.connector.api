using System;

namespace Edel.Adventiel.Connector.Api.Models.V1.Cattles
{
    public class CattleIdentityModel
    {
        public string Name { get; set; }

        public string BreedCode { get; set; }
        
        public DateTime? BirthDate { get; set; }
        
        public string Sex { get; set; }
    }
}