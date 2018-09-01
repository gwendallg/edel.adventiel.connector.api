using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Models.Bovines.Breeding
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "bovineInsemination")]
    [Resource]
    public class BovineInsemination : BovineEvent
    {
        public BovineInseminator Inseminator { get; set; }
        public BovineBreedingBull BreedingBull { get; set; }
        public bool? AiForEmbryoCollect { get; set; }
        public string DocumentReference { get; set; }
        public bool? HormonalTreatment { get; set; }
        public bool? AiByBreeder { get; set; }
        public bool? AiRecognized { get; set; }
    }
}