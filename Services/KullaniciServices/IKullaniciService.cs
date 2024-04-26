using OdiAdmin.Models;

namespace OdiAdmin.Services.KullaniciServices
{
    public interface IKullaniciService
    {
        Task<OdiResult> KullaniciListesiGetir();
    }
}
