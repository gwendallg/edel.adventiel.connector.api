﻿using System;
using System.ComponentModel.DataAnnotations;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Api.Models
{
    [BsonIgnoreExtraElements]
    [Collection(Name = "subscription")]
    [Entity(Name = "subscription")]
    public class Subscription : Metadataeable
    {
        /// <summary>
        /// user id
        /// </summary>
        [Required]
        [BsonId]
        [Id]
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
        public DateTime? LastImportDate { get; set; }

        /// <summary>
        /// last message 
        /// </summary>
        [Ignore]
        public string LastImportMessage { get; set; }

        /// <summary>
        /// status
        /// </summary>
        //[JsonConverter(typeof(StringEnumConverter))]
        //[BsonRepresentation(BsonType.String)]
        public string LastImportStatus { get; set; }
    }
}