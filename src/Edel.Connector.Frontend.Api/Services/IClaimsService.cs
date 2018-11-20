using System;
using System.Collections.Generic;
using Edel.Connector.Api.Models;

namespace Edel.Connector.Api.Services
{
    public interface IClaimsService
    {

        IList<Claim> All();

        Claim FindByResourcePath(string resourcePath);

        Claim FindByEntityType(Type entityType);
        
        IList<ScopeType> Parse(string resourcePath, string scopes);
    }
}