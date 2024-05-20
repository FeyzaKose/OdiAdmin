
using OdiAdmin.Handler;
using OdiAdmin.Models;
using OdiAdmin.Models.UygulamaAyarlari;
using OdiAdmin.Tools;
using System.Collections.Generic;

namespace OdiAdmin.Services.KullaniciServices
{
    public class KullaniciService:IKullaniciService
    {
        private readonly HttpClient _client;

        public KullaniciService(HttpClient client)
        {
            _client = client;
			
		}
        public async Task<ApiResponse<List<Kullanici>>> YetenekTemsilcisiListeGetir()
        {
          return await _client.GetFromJsonAsync<ApiResponse<List<Kullanici>>>(Endpoints.GlobalKullanici.YetenekTemsilcisiListe);
        }
    }
}
