using System;
using System.Collections.Generic;

namespace Edel.Connector.Models
{
    public class Claim
    {
        public string ResourcePath { get; set; }
        public Type ResourceType { get; set; }
        public IList<ScopeType> Scopes { get; set; }
    }
}