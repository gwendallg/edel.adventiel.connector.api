﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Edel.Connector.Frontend.Api.Models.Users
{
    public class UserPutRequestModel
    {
        [Required]
        public string Password { get; set; }
        [Required]
        public List<ClaimRequestModel> Claims { get; set; }
    }
}