using System;
using System.ComponentModel.DataAnnotations;

namespace Edel.Adventiel.Connector.Entities.Cattles
{
    public abstract class AbstractCattleBreederEvent : AbstractBreederData
    {
        
        [Required] public DateTime EventDate { get; set; }
        
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