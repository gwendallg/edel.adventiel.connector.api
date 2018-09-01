using System;
using Edel.Connector.Exceptions;

namespace Edel.Connector.Services.Exceptions
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