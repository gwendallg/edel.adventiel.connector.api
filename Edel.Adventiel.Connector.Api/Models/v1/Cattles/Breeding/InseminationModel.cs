using System;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;

namespace Edel.Adventiel.Connector.Api.Models.V1.Cattles.Breeding
{
    [Collection(Name = "insemination")]
    [Entity(Name = "cattle/insemination")]
    public class InseminationModel : AbstractCattleDataModel
    {
        public DateTime InseminationDate { get; set; }
    }
}