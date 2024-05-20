using OdiAdmin.Models;
using OdiAdmin.Models.UygulamaAyarlari;

namespace OdiAdmin.Services.UygulamaAyarlari.FizikselOzellikler
{
    public interface IFizikselOzellikService
    {
        Task<ApiResponse<List<FizikselOzellikTipi>>> FizikselOzellikTipiListe(int dilId);
        Task<ApiResponse<List<FizikselOzellikTipi>>> YeniFizikselOzellikTipi(FizikselOzellikTipi tip);
        Task<ApiResponse<List<FizikselOzellikTipi>>> FizikselOzellikTipiGuncelle(FizikselOzellikTipi tip);
    }
}
