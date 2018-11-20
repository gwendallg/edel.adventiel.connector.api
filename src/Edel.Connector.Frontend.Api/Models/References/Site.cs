using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using Edel.Connector.Models;

namespace Edel.Connector.Api.Models.References
{
    [Collection(Name = "site")]
    [Resource(Name = "site", Insertable = false, Updatable = false, Deletable = false)]
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Site : Entity
    {
        public string Name { get; set; }
    }
}