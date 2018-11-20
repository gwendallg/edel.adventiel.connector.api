using System;

namespace Edel.Connector.Api.Exceptions
{
    public class ClaimsException : ConnectorException
    {
        public ClaimsException(string message) : base(message)
        {
        }

        public ClaimsException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}