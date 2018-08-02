using System;
using System.ComponentModel.DataAnnotations;

namespace Edel.Connector.Models.Cattles
{
    public abstract class CattleBreederEvent : BreederEntity
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