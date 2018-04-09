using System.ComponentModel.DataAnnotations;

namespace Edel.Adventiel.Connector.Entities.Cattles
{
    public abstract class AbstractCattleData : AbstractBreederData
    {
        [Required] public string CattleIdentifier { get; set; }

        [Required] public string CattleCountryCode { get; set; }
    }
}