using System;
using System.ComponentModel.DataAnnotations;

namespace Edel.Connector.Models.Bovines
{
    public abstract class BovineEvent : BreederEntity
    {
        
        [Required] public DateTime EventDate { get; set; }
        
        /// <summary>
        /// cattle identifier
        /// </summary>
        [Required] public string BovineIdentifier { get; set; }

        /// <summary>
        /// catte country code
        /// </summary>
        [Required] public string BovineCountryCode { get; set; }
    }
}