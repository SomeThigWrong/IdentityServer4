using IdentityModel.Client;

namespace WebAPIDemo.Services
{
    public interface IIdentityServer4Service
    {
        Task<TokenResponse> GetToken(string apiScope);
    }
}
