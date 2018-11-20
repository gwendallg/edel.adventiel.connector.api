using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Autumn.Mvc.Data.Configurations;
using Edel.Connector.Api.Exceptions;
using Edel.Connector.Api.Models;

namespace Edel.Connector.Api.Services
{
    public class ClaimsService : IClaimsService
    {
        private readonly IList<Claim> _claims;
        private readonly AutumnDataSettings _dataSettings;

        public ClaimsService(AutumnDataSettings dataSettings)
        {
            _dataSettings = dataSettings;
            _claims = Build();
        }
    
        private IList<Claim> Build()
        {
            var result = new List<Claim>();
            foreach (var item in _dataSettings.ResourceInfos)
            {
                var scopes = new List<ScopeType> {ScopeType.Read};
                if (!item.Value.IgnoreOperations.Contains(HttpMethod.Post))
                {
                    scopes.Add(ScopeType.Create);
                }

                if (!item.Value.IgnoreOperations.Contains(HttpMethod.Put))
                {
                    scopes.Add(ScopeType.Update);
                }

                if (!item.Value.IgnoreOperations.Contains(HttpMethod.Delete))
                {
                    scopes.Add(ScopeType.Delete);
                }

                var resource = _dataSettings.NamingStrategy == null
                    ? item.Value.Name
                    : _dataSettings.NamingStrategy.GetPropertyName(item.Value.Name, false);

                var claim = new Claim()
                {
                    ResourcePath = $"{item.Value.ApiVersion}/{resource}",
                    ResourceType = item.Key,
                    Scopes = scopes

                };
                result.Add(claim);
            }
            
            // claims for user
            result.Add(new Claim()
            {
                ResourcePath = "v1/user",
                ResourceType = typeof(User),
                Scopes = new List<ScopeType>(new []{ScopeType.Read,ScopeType.Create,ScopeType.Update,ScopeType.Delete})
            });
            
            // claims for subscription
            result.Add(new Claim()
            {
                ResourcePath = "v1/subscription",
                ResourceType = typeof(Subscription),
                Scopes = new List<ScopeType>(new []{ScopeType.Read,ScopeType.Create,ScopeType.Update})
            });
            
            // claims for claim
            result.Add(new Claim()
            {
                ResourcePath = "v1/claim",
                ResourceType = typeof(Claim),
                Scopes = new List<ScopeType>(new []{ScopeType.Read})
            });
            return result;
        }


        public IList<Claim> All()
        {
            return _claims;
        }

        public Claim FindByResourcePath(string resourcePath)
        {
            return _claims.SingleOrDefault(c => c.ResourcePath == resourcePath);
        }

        public Claim FindByEntityType(Type entityType)
        {
            return _claims.SingleOrDefault(c => c.ResourceType == entityType);
        }

        public IList<ScopeType> Parse(string resourcePath, string scopes)
        {
            if(string.IsNullOrWhiteSpace(scopes)) throw new ArgumentNullException(nameof(scopes));
            var claims = FindByResourcePath(resourcePath);
            if (claims == null) throw new ClaimsException($"Claims not found for resource path {resourcePath}");
            var result = new List<ScopeType>();
            foreach (var item in scopes.Split(','))
            {
                if (Enum.TryParse(typeof(ScopeType), item, true, out var scopeType))
                {
                    if (claims.Scopes.Contains((ScopeType)scopeType))
                    {
                        result.Add((ScopeType)scopeType);
                    }
                    else
                    {
                        throw new ClaimsException($"Scope {scopeType} not authorized for resource path {resourcePath}");
                    }
                }
                else
                {
                    throw new ClaimsException($"Scope {item} not valid for resource path {resourcePath}");
                }
            }
            return result;
        }


    }
}