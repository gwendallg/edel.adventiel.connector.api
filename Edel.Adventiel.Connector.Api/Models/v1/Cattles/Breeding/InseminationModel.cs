using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Api.Models.V1.Cattles.Breeding
{
    public class InseminationModel : AbstractCattleDataModel
    {
        [BsonElement("insemination_date")]
        public DateTime InseminationDate { get ; set; }
    }
}