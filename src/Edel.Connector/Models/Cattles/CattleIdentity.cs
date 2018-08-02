using System;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Models.Cattles
{
    [BsonIgnoreExtraElements]
    // ReSharper disable once ClassNeverInstantiated.Global
    public class CattleIdentity
    {
        /// <summary>
        /// name of cattle
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// breed code
        /// </summary>
        public string BreedCode { get; set; }
        
        /// <summary>
        /// birth date of cattle
        /// </summary>
        public DateTime? BirthDate { get; set; }
        
        /// <summary>
        /// sex of cattle
        /// </summary>
        public string Sex { get; set; }
    }
}