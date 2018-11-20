using System.ComponentModel.DataAnnotations;
using Edel.Connector.Models;

namespace Edel.Connector.Api.Models.Bovines.Breeding
{
    public class BovineInseminator
    {
        [Required] public Enterprise Enterprise { get; set; }
        [Required] public string Code { get; set; }
    }
}