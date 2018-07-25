using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;

namespace Edel.Connector.Entities.References
{
    [Collection(Name = "site")]
    [Entity(Name = "site", Insertable = false, Updatable = false, Deletable = false)]
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Site : Entity
    {
        public string Name { get; set; }
    }
}