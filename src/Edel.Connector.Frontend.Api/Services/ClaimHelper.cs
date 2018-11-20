using System.Collections.Generic;
using System.Linq;
using Edel.Connector.Api.Models;

namespace Edel.Connector.Api.Services
{
    public static class ClaimHelper
    {
        public static string ToString(IEnumerable<ScopeType> scopes)
        {
            return scopes
                .OrderBy(o => o)
                .Select(c => c.ToString().ToLowerInvariant())
                .Aggregate((a, b) => a + ", "+ b);
        }
    }
}