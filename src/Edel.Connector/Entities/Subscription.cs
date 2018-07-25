using System;
using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Entities
{
    [BsonIgnoreExtraElements]
    public class Subscription : Metadataeable
    {
        /// <summary>
        /// user id
        /// </summary>
        [Required]
        [BsonId]
        public string UserId { get; set; }

        /// <summary>
        /// hash of EDEL password
        /// </summary>
        [Required]
        public string Hash { get; set; }

        /// <summary>
        /// is active subscription
        /// </summary>
        public bool Active { get; set; }

        /// <summary>
        /// last collect datetime
        /// </summary>
        [Ignore]
        public DateTime? LastCollectTime { get; set; }

        /// <summary>
        /// last message 
        /// </summary>
        [Ignore]
        public string LastMessage { get; set; }
    }
}