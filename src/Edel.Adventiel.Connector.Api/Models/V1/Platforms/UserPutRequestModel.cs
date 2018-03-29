using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Edel.Adventiel.Connector.Api.Models.V1.Platforms
{
    public class UserPutRequestModel
    {
        [Required]
        public string Password { get; set; }
        [Required]
        public List<ClaimModel> Claims { get; set; } 
    }
}