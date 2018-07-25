using System.ComponentModel.DataAnnotations;

// ReSharper disable All

namespace Edel.Connector.Frontend.Api.Models.Auths
{
    public class AuthTokenRequestModel
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        public string Password { get; set; }
    }
}