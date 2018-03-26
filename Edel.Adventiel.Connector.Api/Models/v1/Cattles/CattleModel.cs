using Autumn.Mvc.Data.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Api.Models.V1.Cattles
{
    [BsonIgnoreExtraElements]
    [Entity(Name = "cattle")]
    public class CattleModel : AbstractCattleDataModel
    {
        public CattleIdentityModel Identity { get; set; }
    }
}