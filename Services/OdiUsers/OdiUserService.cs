using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using OdiAdmin.Handler;
using OdiAdmin.Models;
using OdiAdmin.Tools;
using RestSharp;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace OdiAdmin.Services.OdiUsers
{
    public class OdiUserService:IOdiUserService
    {

        private readonly HttpClient _client;

        public OdiUserService(HttpClient client)
        {
            _client = client;
        }
        public async Task<OdiUser> GetUser()
        {
            ApiResponse<OdiUser> resp = await _client.GetFromJsonAsync<ApiResponse<OdiUser>>(Endpoints.Kullanici.GetirByToken);

            OdiUser user = resp.Data;


            return user;
        }
    }
}
