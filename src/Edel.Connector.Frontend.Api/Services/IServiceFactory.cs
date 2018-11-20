namespace Edel.Connector.Api.Services
{
    public interface IServiceFactory
    {
        T Get<T>();
    }
}