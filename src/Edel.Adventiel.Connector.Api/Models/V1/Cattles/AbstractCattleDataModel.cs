using System.ComponentModel.DataAnnotations;

namespace Edel.Adventiel.Connector.Api.Models.V1.Cattles
{
    public abstract class AbstractCattleDataModel : AbstractElementModel<MetadataWithOriginModel>
    {
        [Required]
        public string CattleIdentifier { get; set; }
        
        [Required]
        public string CattleCountryCode { get; set; }

        [Required]
        public string BreederIdentifier { get; set; }
        
        [Required]
        public string BreederCountryCode { get; set; }

    }
}