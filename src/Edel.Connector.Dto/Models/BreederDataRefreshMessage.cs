using System;

namespace Edel.Connector.Dto.Models
{
    public class BreederDataRefreshMessage
    {
        public string Identifier { get; set; }
        public bool IsHealthCheck { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}