namespace Edel.Adventiel.Connector.Api.Services
{
    public interface ISecurityService
    {
        string GetHash(string password,string salt);
        string GetSalt();
    }
}