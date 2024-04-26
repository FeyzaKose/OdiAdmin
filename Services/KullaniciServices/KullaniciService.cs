
using OdiAdmin.Handler;
using OdiAdmin.Models;
using OdiAdmin.Tools;

namespace OdiAdmin.Services.KullaniciServices
{
    public class KullaniciService:IKullaniciService
    {
        private readonly IApiHandler _apiHandler;
        public KullaniciService(IApiHandler apiHandler)
        {
            _apiHandler = apiHandler;
        }
        public async Task<OdiResult> KullaniciListesiGetir()
        {
            return await _apiHandler.GetAsync<List<Kullanici>>(Endpoints.Kullanici.YetenekTemsilcisiListe);
        }
    }
}
