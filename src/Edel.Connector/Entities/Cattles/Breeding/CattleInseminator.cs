using System.ComponentModel.DataAnnotations;

namespace Edel.Connector.Entities.Cattles.Breeding
{
    public class CattleInseminator
    {
        [Required] public Enterprise Enterprise { get; set; }
        [Required] public string Code { get; set; }
    }
}