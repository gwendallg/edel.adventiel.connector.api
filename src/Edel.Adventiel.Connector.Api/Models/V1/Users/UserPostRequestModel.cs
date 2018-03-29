using System.ComponentModel.DataAnnotations;

namespace Edel.Adventiel.Connector.Api.Models.V1.Users
{
    public class UserPostRequestModel : UserPutRequestModel
    {
        [Required]
        public string Username { get; set; }
    }
}