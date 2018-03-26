using Autumn.Mvc.Data.Annotations;

namespace Edel.Adventiel.Connector.Api.Models.V1.Cattles
{
    [Entity(Name = "cattle")]
    public class CattleModel : AbstractCattleDataModel
    {
        public CattleIdentityModel Identity { get; set; }
    }
}