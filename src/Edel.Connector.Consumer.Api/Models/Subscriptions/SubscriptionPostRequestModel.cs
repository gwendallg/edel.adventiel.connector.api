using System.ComponentModel.DataAnnotations;

namespace Edel.Connector.Consumer.Api.Models.Subscriptions
{
    public class SubscriptionPostRequestModel : SubscriptionPutRequestModel
    {
        /// <summary>
        /// user id
        /// </summary>
        [Required]
        public string UserId { get; set; }

    }
}