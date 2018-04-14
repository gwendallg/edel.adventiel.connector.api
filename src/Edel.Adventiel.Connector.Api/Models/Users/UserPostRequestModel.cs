using System.ComponentModel.DataAnnotations;

namespace Edel.Adventiel.Connector.Api.Models.Users
{
    public class UserPostRequestModel : UserPutRequestModel
    {
        [Required]
        public string UserName { get; set; }
    }
}