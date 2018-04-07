using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Entities.References
{
    [Collection(Name = "departement")]
    [Entity(Name = "departement", Insertable = false, Updatable = false, Deletable = false)]
    public class Department
    {
        [BsonId] [Required] [Id] public string Id { get; set; }
        [Required] public string SiteId { get; set; }
        [Required] public string Enterprise { get; set; }
    }
}