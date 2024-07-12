using OdiAdmin.Models;
using OdiAdmin.Models.CVAyarlari;

namespace OdiAdmin.Services.CVAyarlari.FizikselOzellikler
{
    public interface IFizikselOzellikService
    {
        Task<ApiResponse<List<FizikselOzellikTipi>>> FizikselOzellikTipiListe(int dilId);
        Task<ApiResponse<List<FizikselOzellikTipi>>> YeniFizikselOzellikTipi(FizikselOzellikTipi tip);
        Task<ApiResponse<List<FizikselOzellikTipi>>> FizikselOzellikTipiGuncelle(FizikselOzellikTipi tip);
        Task<ApiResponse<List<FizikselOzellikTipi>>> FizikselOzellikTipiDurumDegistir(FizikselOzellikTipIdDTO tipId);
    }
}
