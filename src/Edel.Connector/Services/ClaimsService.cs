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

        private readonly AutumnDataSettings _dataSettings;

        public ClaimsService(AutumnDataSettings dataSettings)
        {
            _dataSettings = dataSettings;
        }

        public IDictionary<Type, IList<ScopeType>> GetClaimsByResources()
        {
            return null;
        }

        public IList<ScopeType> GetClaimsByResource(string resource)
        {
            return null;
        }


        public IList<ScopeType> GetClaimsByEntityType(Type entityType)
        {
            var result = new List<ScopeType>();
            if (_dataSettings.EntitiesInfos.ContainsKey(entityType))
            {
                var item = _dataSettings.EntitiesInfos[entityType];
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
                if (typeof(User) == entityType)
                {
                    return new List<ScopeType>(new[]
                        {ScopeType.Read, ScopeType.Create, ScopeType.Update, ScopeType.Delete}));
                }

                if (typeof(Subscription) == entityType)
                {
                    new List<ScopeType>(new[] {ScopeType.Read, ScopeType.Create, ScopeType.Update}));
                }
            }

            return null;
        }

        public IDictionary<Type, IList<ScopeType>> GetClaimsByEntityType()
        {
            var result =
                _dataSettings.EntitiesInfos.ToDictionary(item => item.Key, item => GetClaimsByEntityType(item.Key));
            result.Add(typeof(User), GetClaimsByEntityType(typeof(User)));
            result.Add(typeof(Subscription), GetClaimsByEntityType(typeof(Subscription)));
            return result;
        }

        public bool TryParse(string s, out IList<ScopeType> result)
        {
            result = new List<ScopeType>();
            return true;

        }
    }
}