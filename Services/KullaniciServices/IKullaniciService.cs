using OdiAdmin.Models;

namespace OdiAdmin.Services.KullaniciServices
{
    public interface IKullaniciService
    {
        Task<ApiResponse<List<Kullanici>>> YetenekTemsilcisiListeGetir();
    }
}
