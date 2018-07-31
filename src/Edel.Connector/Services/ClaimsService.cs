using System;
using System.Linq;
using System.Collections.Generic;
using System.Net.Http;
using Autumn.Mvc.Data.Configurations;
using Edel.Connector.Entities;

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
                "v1_user",typeof(User)
            },
            {
                "v1_subscription",typeof(Subscription)
            }
        };

        
        private readonly AutumnDataSettings _dataSettings;

        public ClaimsService(AutumnDataSettings dataSettings)
        {
            _dataSettings = dataSettings;
        }

        public IDictionary<string, IList<ScopeType>> GetClaimsByResources()
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
                result.Add($"{item.Value.ApiVersion}_{item.Value.Name}", scopes);
            }

            foreach (var item in MappingStringToTypes)
            {
                result.Add(item.Key,GetClaimsByEntityType(item.Value));
            }
            return result;
        }

        public IList<ScopeType> GetClaimsByResource(string resource)
        {
            var items = GetClaimsByResources();
            return items.ContainsKey(resource) ? items[resource] : null;
        }

        public IList<ScopeType> GetClaimsByEntityType(Type entityType)
        {
            var result = new List<ScopeType>();
            if (_dataSettings.ResourceInfos.ContainsKey(entityType))
            {
                var item = _dataSettings.ResourceInfos[entityType];
                if (!item.IgnoreOperations.Contains(HttpMethod.Post))
                {
                    result.Add(ScopeType.Create);
                }

                if (!item.IgnoreOperations.Contains(HttpMethod.Put))
                {
                    result.Add(ScopeType.Update);
                }

                if (!item.IgnoreOperations.Contains(HttpMethod.Delete))
                {
                    result.Add(ScopeType.Delete);
                }
            }
            else
            {
                if (MappingTypeToClaims.ContainsKey(entityType))
                {
                    return MappingTypeToClaims[entityType];
                }
            }

            return null;
        }

        public IDictionary<Type, IList<ScopeType>> GetClaimsByEntityType()
        {
            var result =
                _dataSettings.EntitiesInfos.ToDictionary(item => item.Key, item => GetClaimsByEntityType(item.Key));
            foreach (var item in MappingTypeToClaims)
                result.Add(item.Key, item.Value);
            return result;
        }

        public bool TryParse(string s, out IList<ScopeType> result)
        {
            result = new List<ScopeType>();
            return true;

        }
    }
}