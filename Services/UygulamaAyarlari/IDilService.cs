using OdiAdmin.Models;
using OdiAdmin.Models.UygulamaAyarlari;

namespace OdiAdmin.Services.UygulamaAyarlari
{
    public interface IDilService
    {
        Task<ApiResponse<List<Dil>>> DilListesiAsyc();
        Task<List<Dil>> SessionDilListesiAsyc();
        bool CheckSessionDilListesi();
    }
}
