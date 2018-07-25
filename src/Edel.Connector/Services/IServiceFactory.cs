namespace Edel.Connector.Services
{
    public interface IServiceFactory
    {
        T Get<T>();
    }
}