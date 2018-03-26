using Autumn.Mvc.Data.Annotations;
using Edel.Adventiel.Connector.Api.Models.V1;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Api.Models
{
   
    public abstract class AbstractElementModel
    {
        [Id]
        [BsonId]
        [Ignore]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        [Ignore]
        public MetaDataModel Metadata { get; set; }
    }
}