// ReSharper disable All

namespace Edel.Connector.Frontend.Api.Models.Auths
{
    public class AuthTokenResponseModel
    {
        public string TokenType { get; set; }
        public string AccessToken { get; set; }
        public int ExpiresIn { get; set; }
        public string RefreshToken { get; set; }
    }
}