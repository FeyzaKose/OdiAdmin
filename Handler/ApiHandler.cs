using OdiAdmin.Models;
using OdiAdmin.Tools;

namespace OdiAdmin.Handler
{
    public  class ApiHandler:IApiHandler
    {
        private readonly HttpClient _client;
        public ApiHandler(HttpClient client)
        {
            _client = client;
        }

        public  async  Task<OdiResult> GetAsync<T>(string endpoint)
        {
            OdiResult result = new OdiResult();
            ApiResponse<T> resp = await _client.GetFromJsonAsync<ApiResponse<T>>(endpoint);

            result.Sonuc = resp.IsSuccessful;
            result.Mesaj=resp.Message;
            result.Data=resp.Data;

            return result;
        }

         
    }
}
