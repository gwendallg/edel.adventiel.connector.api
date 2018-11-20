using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Api.Models.Bovines
{
    [BsonIgnoreExtraElements]
    // ReSharper disable once ClassNeverInstantiated.Global
    public class BovineIdentity
    {
        /// <summary>
        /// name of bovine
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// breed code of bovine
        /// </summary>
        public string BreedCode { get; set; }
        
        /// <summary>
        /// birth date of bovine
        /// </summary>
        public DateTime? BirthDate { get; set; }
        
        /// <summary>
        /// sex of bovine
        /// </summary>
        public string Sex { get; set; }
    }
}