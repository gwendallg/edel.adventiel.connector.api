using System.ComponentModel.DataAnnotations;

namespace Edel.Adventiel.Connector.Entities.Breeders
{
    public  abstract class AbstractBreederData  : AbstractEntity
    {
        [Required] public string BreederIdentifier { get; set; }

        [Required] public string BreederCountryCode { get; set; }
    }
}