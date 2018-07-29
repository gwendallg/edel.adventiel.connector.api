using System.Collections.Generic;

namespace Edel.Connector.Services
{
    public interface IMessageService
    {
        Dictionary<string, object> GetConfiguration();

        string GetRefreshDataRequestTopic();
        
    }
}