using System;
using System.Collections.Generic;
using Edel.Connector.Models;

namespace Edel.Connector.Services
{
    public interface IClaimsService
    {

        IList<Claim> All();

        Claim FindByResourcePath(string resourcePath);

        Claim FindByEntityType(Type entityType);
        
        IList<ScopeType> Parse(string resourcePath, string scopes);
    }
}