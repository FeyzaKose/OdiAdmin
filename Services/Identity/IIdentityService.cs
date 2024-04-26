using IdentityModel.Client;
using OdiAdmin.Models;
using OdiAdmin.Models.AccountModels;

namespace OdiAdmin.Services.Identity
{
    public interface IIdentityService
    {
        Task<ApiResponse<bool>> SignIn(SignInInput signinInput);

        Task<TokenResponse> GetAccessTokenByRefreshToken();

        Task RevokeRefreshToken();
    }
}
