using System;
using Autumn.Mvc.Data.Annotations;
using Autumn.Mvc.Data.MongoDB.Annotations;

namespace Edel.Connector.Models
{
    [Collection(Name = "refreshToken")]
    [Entity]
    public class RefreshToken
    {
        [Id]
        public string Id { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string UserName { get; set; }
    }
}