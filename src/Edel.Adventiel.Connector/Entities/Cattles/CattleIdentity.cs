using System;

namespace Edel.Adventiel.Connector.Entities.Cattles
{
    public class CattleIdentity
    {
        public string Name { get; set; }

        public string BreedCode { get; set; }
        
        public DateTime? BirthDate { get; set; }
        
        public string Sex { get; set; }
    }
}