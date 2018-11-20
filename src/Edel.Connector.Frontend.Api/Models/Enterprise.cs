using Edel.Connector.Models;
using MongoDB.Bson.Serialization.Attributes;

namespace Edel.Connector.Api.Models
{
    [BsonIgnoreExtraElements]
    // ReSharper disable once ClassNeverInstantiated.Global
    public class Enterprise
    {
        public Registration Registration { get; set; }
    }
}