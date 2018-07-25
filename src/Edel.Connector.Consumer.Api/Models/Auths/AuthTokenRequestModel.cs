using System.ComponentModel.DataAnnotations;

// ReSharper disable All

namespace Edel.Connector.Consumer.Api.Models.Auths
{
    public class AuthTokenRequestModel
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        public string Password { get; set; }
    }
}