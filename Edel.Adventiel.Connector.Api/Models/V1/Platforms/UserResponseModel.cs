using System.Collections.Generic;

namespace Edel.Adventiel.Connector.Api.Models.V1.Platforms
{
    public class UserResponseModel
    {
        public string Username { get; set; }
        public string Salt { get; set; }
        public string Hash { get; set; }
        public List<ClaimModel> Claims { get; set; }
        public MetaDataModel Metadata { get; set; }
    }
}