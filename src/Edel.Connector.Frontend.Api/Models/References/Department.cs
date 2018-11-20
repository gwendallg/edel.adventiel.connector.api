using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using Edel.Connector.Models;

namespace Edel.Connector.Api.Models.References
{
    [Collection(Name = "department")]
    [Resource(Name = "department", Insertable = false, Updatable = false, Deletable = false)]
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Department : Entity
    {
        [Required] public string SiteId { get; set; }
        [Required] public string Enterprise { get; set; }
    }
}