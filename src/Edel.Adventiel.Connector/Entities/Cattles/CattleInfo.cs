using System.ComponentModel.DataAnnotations;

namespace Edel.Adventiel.Connector.Entities.Cattles
{
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