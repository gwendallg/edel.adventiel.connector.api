using System.ComponentModel.DataAnnotations;

namespace Edel.Connector.Models.Cattles.Breeding
{
    public class CattleInseminator
    {
        [Required] public Enterprise Enterprise { get; set; }
        [Required] public string Code { get; set; }
    }
}