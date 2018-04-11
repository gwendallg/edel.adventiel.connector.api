using System.ComponentModel.DataAnnotations;

namespace Edel.Adventiel.Connector.Entities
{
    public abstract class AbstractReferenceEntity : AbstractEntityWithId
    {
        [Required] public string Label { get; set; }
    }
}