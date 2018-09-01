using System.ComponentModel.DataAnnotations;

namespace Edel.Connector.Models.Bovines.Breeding
{
    public class BovineInseminator
    {
        [Required] public Enterprise Enterprise { get; set; }
        [Required] public string Code { get; set; }
    }
}