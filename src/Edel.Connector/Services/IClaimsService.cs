using System;
using System.Collections.Generic;
using Edel.Connector.Models;

namespace Edel.Connector.Services
{
    public interface IClaimsService
    {
        IDictionary<Type, IList<ScopeType>> GetClaimsByEntityTypes();

        IDictionary<string, IList<ScopeType>> GetClaimsByResourcePaths();

        IList<ScopeType> GetClaimsByResourcePath(string resourcePath);
        
        IList<ScopeType> GetClaimsByEntityType(Type entityType);
      
        IList<ScopeType> Parse(string resourcePath, string scopes);

        string ToString(IList<ScopeType> scopes);
    }
}