namespace Edel.Adventiel.Connector.Services
{
    public interface IServiceFactory
    {
        T Get<T>();
    }
}