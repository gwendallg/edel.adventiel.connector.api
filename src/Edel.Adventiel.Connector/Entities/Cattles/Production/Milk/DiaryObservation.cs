using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Entities.Cattles.Production.Milk
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "cattleDiaryObservation")]
    [Entity(Name = "cattle-diary-observation")]
    public class DiaryObservation : AbstractCattleData
    {
        public int LactationNumber { get; set; }
        public string FemaleStateCode { get; set; }
        public int? ControlNumber { get; set; }
        public decimal DiaryObservationMilk { get; set; }
        public string CauseAbscenceRate { get; set; }
        public decimal? Protein { get; set; }
        public decimal? Fat { get; set; }
        public decimal? Urea { get; set; }
        public decimal? Cell { get; set; }
        public bool? LiuIndicator { get; set; }
    }
}