using System.Collections.Generic;

namespace Edel.Connector.Dto.Services
{
    public interface IMessageService
    {
        Dictionary<string, object> GetConfiguration();

        string GetRefreshDataRequestTopic();
        
    }
}