using System.ComponentModel.DataAnnotations;

namespace Edel.Adventiel.Connector.Entities.Cattles
{
    public abstract class AbstractCattleData : AbstractEntity
    {
        [Required]
        public string CattleIdentifier { get; set; }
        
        [Required]
        public string CattleCountryCode { get; set; }

        [Required]
        public string BreederIdentifier { get; set; }
        
        [Required]
        public string BreederCountryCode { get; set; }

    }
}