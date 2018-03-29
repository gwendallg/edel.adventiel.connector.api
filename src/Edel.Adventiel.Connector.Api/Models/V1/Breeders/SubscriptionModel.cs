using System;
using Autumn.Mvc.Data.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Api.Models.V1.Breeders
{

    [BsonIgnoreExtraElements]
    [Entity(Name = "breeder-subscription")]
    public class SubscriptionModel : AbstractElementModel<MetadataModel>
    {
        public string Login { get; set; }
        
        public string Password { get; set; }

        [Ignore(Insertable = true, Updatable = true)]
        public DateTime? LastImportDate { get; set; }
    }
}