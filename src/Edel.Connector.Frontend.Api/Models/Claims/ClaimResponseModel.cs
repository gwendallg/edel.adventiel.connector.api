using System.Collections.Generic;

namespace Edel.Connector.Api.Models.Claims
{
    public class ClaimResponseModel
    {
        public string ResourcePath { get; set; }
        public IList<string> Scopes { get; set; }
    }
}