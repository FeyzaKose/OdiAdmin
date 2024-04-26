using OdiAdmin.Models;

namespace OdiAdmin.Services.OdiUsers
{
    public interface IOdiUserService
    {
        Task<OdiUser> GetUser();

    }
}
