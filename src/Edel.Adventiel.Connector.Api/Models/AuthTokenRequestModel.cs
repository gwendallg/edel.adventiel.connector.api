using System.ComponentModel.DataAnnotations;
// ReSharper disable All

namespace Edel.Adventiel.Connector.Api.Models.V1.Platforms
{
    public class AuthTokenRequestModel
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        public string Password { get; set; }
    }
}