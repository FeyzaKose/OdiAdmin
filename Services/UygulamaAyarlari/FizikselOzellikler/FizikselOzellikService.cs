using OdiAdmin.Models;
using OdiAdmin.Models.UygulamaAyarlari;
using OdiAdmin.Tools;

namespace OdiAdmin.Services.UygulamaAyarlari.FizikselOzellikler
{
    public class FizikselOzellikService:IFizikselOzellikService
    {
        private readonly HttpClient _client;

        public FizikselOzellikService(HttpClient client)
        {
            _client = client;
        }

        public async Task<ApiResponse<List<FizikselOzellikTipi>>> FizikselOzellikTipiListe(int dilId)
        {
            ApiResponse<List<FizikselOzellikTipi>> apiResponse = new ApiResponse<List<FizikselOzellikTipi>>();
            var dilIdObj = new DilIdObj { DilId = dilId };

            var response = await _client.PostAsJsonAsync(Endpoints.UygulamaBilgileri.FizikselOzellikler.TipListesi, dilIdObj);

            if (response.IsSuccessStatusCode)
            {
                 apiResponse = await response.Content.ReadFromJsonAsync<ApiResponse<List<FizikselOzellikTipi>>>();
            }
            else
            {
                apiResponse.IsSuccessful = false;
                apiResponse.Message = "Api request sırasında bir sorun oluştu";
            }
            return apiResponse;
        }

        public async Task<ApiResponse<List<FizikselOzellikTipi>>> YeniFizikselOzellikTipi(FizikselOzellikTipi tip)
        {
            ApiResponse<List<FizikselOzellikTipi>> apiResponse = new ApiResponse<List<FizikselOzellikTipi>>();

            var response = await _client.PostAsJsonAsync(Endpoints.UygulamaBilgileri.FizikselOzellikler.YeniTip, tip);

            if (response.IsSuccessStatusCode)
            {
                apiResponse = await response.Content.ReadFromJsonAsync<ApiResponse<List<FizikselOzellikTipi>>>();
            }
            else
            {
                apiResponse.IsSuccessful = false;
                apiResponse.Message = "Api request sırasında bir sorun oluştu";
            }
            return apiResponse;
        }

        public async Task<ApiResponse<List<FizikselOzellikTipi>>> FizikselOzellikTipiGuncelle(FizikselOzellikTipi tip)
        {
            ApiResponse<List<FizikselOzellikTipi>> apiResponse = new ApiResponse<List<FizikselOzellikTipi>>();

            var response = await _client.PostAsJsonAsync(Endpoints.UygulamaBilgileri.FizikselOzellikler.TipGuncelle, tip);

            if (response.IsSuccessStatusCode)
            {
                apiResponse = await response.Content.ReadFromJsonAsync<ApiResponse<List<FizikselOzellikTipi>>>();
            }
            else
            {
                apiResponse.IsSuccessful = false;
                apiResponse.Message = "Api request sırasında bir sorun oluştu";
            }
            return apiResponse;
        }
        private class DilIdObj
        {
            public int DilId { get; set; }
        }
    }
}
