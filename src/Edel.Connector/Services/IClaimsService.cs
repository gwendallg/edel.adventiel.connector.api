using System;
using System.Collections.Generic;

namespace Edel.Connector.Services
{
    public interface IClaimsService
    {
        IDictionary<Type, IList<ScopeType>> GetClaimsByEntityType();

        IDictionary<Type, IList<ScopeType>> GetClaimsByResources();

        IList<ScopeType> GetClaimsByResource(string resource);

        IList<ScopeType> GetClaimsByEntityType(Type entityType);
      
        bool TryParse(string s, out IList<ScopeType> result);
    }
}