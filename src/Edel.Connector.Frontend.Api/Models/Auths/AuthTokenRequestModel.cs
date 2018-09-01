using System.ComponentModel.DataAnnotations;

// ReSharper disable All

namespace Edel.Connector.Frontend.Api.Models.Auths
{
    public class AuthTokenRequestModel
    {
        public string GrantType { get; set; }
        
        public string Username { get; set; }
        
        public string Password { get; set; }
        
        public string RefreshToken { get; set; }
    }
}