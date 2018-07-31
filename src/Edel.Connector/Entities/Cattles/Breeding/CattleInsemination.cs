using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Entities.Cattles.Breeding
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "cattleInsemination")]
    [Resource(Name = "cattle-insemination")]
    public class CattleInsemination : CattleBreederEvent
    {
        public CattleInseminator Inseminator { get; set; }
        public CattleBreedingBull BreedingBull { get; set; }
        public bool? AiForEmbryoCollect { get; set; }
        public string DocumentReference { get; set; }
        public bool? HormonalTreatment { get; set; }
        public bool? AiByBreeder { get; set; }
        public bool? AiRecognized { get; set; }
    }
}