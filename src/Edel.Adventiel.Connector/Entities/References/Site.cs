using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;

namespace Edel.Adventiel.Connector.Entities.References
{
    [Collection(Name = "site")]
    [Entity(Name = "site", Insertable = false, Updatable = false, Deletable = false)]
    public class Site : AbstractEntityWithId
    {
        public string Name { get; set; }
    }
}