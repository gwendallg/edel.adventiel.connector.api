using System.ComponentModel.DataAnnotations;

namespace Edel.Adventiel.Connector.Api.Models.V1.Auth
{
    public class AuthTokenRequest
    {
        [Required]
        public string Username { get; set; }
        
        [Required]
        public string Password { get; set; }
    }
}