using System.ComponentModel.DataAnnotations;

namespace Edel.Adventiel.Connector.Api.Models.Subscriptions
{
    public class SubscriptionPutRequestModel
    {
        /// <summary>
        /// password of subscription
        /// </summary>
        [Required]
        public string Password { get; set; }

        /// <summary>
        /// is active subscription
        /// </summary>
        public bool Active { get; set; }
    }
}