using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.Http;
using Autumn.Mvc.Data.Configurations;
using Edel.Connector.Models;
using Edel.Connector.Services.Exceptions;

namespace Edel.Connector.Services
{
    public class ClaimsService : IClaimsService
    {
        
        private static readonly Dictionary<Type, IList<ScopeType>> MappingTypeToClaims = new Dictionary<Type, IList<ScopeType>>()
        {
            {
                typeof(User),
                new List<ScopeType>(new []{ScopeType.Read,ScopeType.Create,ScopeType.Update})
            },
            {
                typeof(Subscription),
                new List<ScopeType>(new []{ScopeType.Read,ScopeType.Create,ScopeType.Update})
            }
        };

        private static readonly Dictionary<string, Type> MappingStringToTypes = new Dictionary<string, Type>()
        {
            {
                "v1/user",typeof(User)
            },
            {
                "v1/subscription",typeof(Subscription)
            },
        };
        
        private readonly AutumnDataSettings _dataSettings;

        public ClaimsService(AutumnDataSettings dataSettings)
        {
            _dataSettings = dataSettings;
            _claimsByResourcePaths = BuildClaimsByResourcePaths();
            _claimsByEntityTypes = BuildClaimsByEntityTypes();
        }

        private readonly IDictionary<string, IList<ScopeType>> _claimsByResourcePaths;
        private readonly IDictionary<Type, IList<ScopeType>> _claimsByEntityTypes;

        public IDictionary<string, IList<ScopeType>> GetClaimsByResourcePaths()
        {
            return _claimsByResourcePaths;
        }
    
        private IDictionary<string, IList<ScopeType>> BuildClaimsByResourcePaths()
        {
            var result = new Dictionary<string,IList<ScopeType>>();
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
                
                result.Add($"{item.Value.ApiVersion}/{resource}", scopes);
            }

            foreach (var item in MappingStringToTypes)
            {
                result.Add(item.Key,MappingTypeToClaims[item.Value]);
            }
            return result;
        }

        public IList<ScopeType> GetClaimsByResourcePath(string resourcePath)
        {
            var items = _claimsByResourcePaths;
            return items.ContainsKey(resourcePath) ? items[resourcePath] : null;
        }

        public IList<ScopeType> GetClaimsByEntityType(Type entityType)
        {
            var items = _claimsByEntityTypes;
            return items.ContainsKey(entityType) ? items[entityType] : null;
        }

        public IDictionary<Type, IList<ScopeType>> GetClaimsByEntityTypes()
        {
            return _claimsByEntityTypes;
        }

        public IDictionary<Type, IList<ScopeType>> BuildClaimsByEntityTypes()
        {
            var result = new Dictionary<Type,IList<ScopeType>>();
            foreach (var item in _dataSettings.ResourceInfos)
            {
                var scopes = new List<ScopeType>();
                scopes.Add(ScopeType.Read);
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

                result.Add(item.Key, scopes);
            }
            foreach (var item in MappingTypeToClaims)
                result.Add(item.Key, item.Value);
            return result;
        }

        public IList<ScopeType> Parse(string resourcePath, string scopes)
        {
            if(string.IsNullOrWhiteSpace(scopes)) throw new ArgumentNullException(nameof(scopes));
            var claims = GetClaimsByResourcePath(resourcePath);
            if (claims == null) throw new ClaimsException($"Claims not found for resource path {resourcePath}");
            var result = new List<ScopeType>();
            foreach (var item in scopes.Split(','))
            {
                if (Enum.TryParse(typeof(ScopeType), item, true, out var scopeType))
                {
                    if (claims.Contains((ScopeType)scopeType))
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

        public string ToString(IList<ScopeType> scopes)
        {
            return scopes
                .OrderBy(o => o)
                .Select(c => c.ToString().ToLowerInvariant())
                .Aggregate((a, b) => a + ", "+ b);
        }
    }
}