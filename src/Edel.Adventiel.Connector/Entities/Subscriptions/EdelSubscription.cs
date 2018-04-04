using System;
using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Adventiel.Connector.Entities.Subscriptions
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "edelSubscription")]
    [Entity(Name = "edel-subscription")]
    public class EdelSubscription
    {
        [Ignore(Insertable = true)]
        [Required]
        [BsonId]
        [Id]
        public string UserId { get; set; }

        [Required] public string Password { get; set; }

        [Ignore] public Metadata Metadata { get; set; }

        public bool Active { get; set; }

        [Ignore]
        public DateTime? LastCollectTime { get; set; }
    }
}