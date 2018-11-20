using System.Collections.Generic;

namespace Edel.Connector.Api.Models.Users
{
    public class ClaimRequestModel
    {
        public string ResourcePath { get; set; }
        public List<string> Scopes { get; set; }
    }
}