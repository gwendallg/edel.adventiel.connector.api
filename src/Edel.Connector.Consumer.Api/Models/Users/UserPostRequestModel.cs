using System.ComponentModel.DataAnnotations;

namespace Edel.Connector.Consumer.Api.Models.Users
{
    public class UserPostRequestModel : UserPutRequestModel
    {
        [Required]
        public string UserName { get; set; }
    }
}