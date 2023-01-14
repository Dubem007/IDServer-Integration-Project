using IdentityModel.Client;

namespace WebClient.Services
{
    public interface ITokenService
    {
        Task<TokenResponse> GetToken(string scope);
    }
}
