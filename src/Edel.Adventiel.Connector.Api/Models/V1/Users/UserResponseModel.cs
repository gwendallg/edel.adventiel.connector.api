using System.Collections.Generic;

namespace Edel.Adventiel.Connector.Api.Models.V1.Users
{
    public class UserResponseModel
    {
        public string Username { get; set; }
        public string Salt { get; set; }
        public string Hash { get; set; }
        public Dictionary<string,string> Claims { get; set; }
        public MetadataModel Metadata { get; set; }
    }
}