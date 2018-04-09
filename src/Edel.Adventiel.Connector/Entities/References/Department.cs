using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;

namespace Edel.Adventiel.Connector.Entities.References
{
    [Collection(Name = "department")]
    [Entity(Name = "department", Insertable = false, Updatable = false, Deletable = false)]
    public class Department : AbstractEntityWithId
    {
        [Required] public string SiteId { get; set; }
        [Required] public string Enterprise { get; set; }
    }
}