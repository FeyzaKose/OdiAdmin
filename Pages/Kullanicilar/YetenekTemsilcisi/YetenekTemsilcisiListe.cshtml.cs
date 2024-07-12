using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdiAdmin.Models;
using OdiAdmin.Models.PartialViewModels.Kullanicilar;
using OdiAdmin.Services.KullaniciServices;
namespace OdiAdmin.Pages.Kullanicilar.YetenekTemsilcisi
{
    [Authorize]
    public class YetenekTemsilcisiListeModel : PageModel
    {
        [BindProperty]
        public List<Kullanici> YetenekTemsilcileri { get; set; }
        [BindProperty]
        public YeniKullaniciViewModel yeniKullaniciViewModal { get; set; }


        private readonly IKullaniciService _kullaniciService;
        public YetenekTemsilcisiListeModel(IKullaniciService kullaniciService)
        {
            _kullaniciService = kullaniciService;
            yeniKullaniciViewModal = new YeniKullaniciViewModel { SayfaBasligi = "Yeni Yetenek Temsilcisi" };
        }
        public async Task OnGetAsync()
        {
            ApiResponse<List<Kullanici>> res = await _kullaniciService.YetenekTemsilcisiListeGetir();
            int i = 1;
            YetenekTemsilcileri = res.Data;
            //return Content(JsonConvert.SerializeObject(res));
            //return new JsonResult(result);
        }


    }
}
