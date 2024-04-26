using OdiAdmin.Models;

namespace OdiAdmin.Handler
{
    public interface IApiHandler
    {
        Task<OdiResult> GetAsync<T>(string endpoint);
    }
}
