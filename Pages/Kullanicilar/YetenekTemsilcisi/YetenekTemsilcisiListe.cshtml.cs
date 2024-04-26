using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using OdiAdmin.Models;
using OdiAdmin.Services.KullaniciServices;

namespace OdiAdmin.Pages.Kullanicilar.YetenekTemsilcisi
{
    public class YetenekTemsilcisiListeModel : PageModel
    {
        [BindProperty]
        List<Kullanici> YetenekTemsilcileri { get; set; }


        IKullaniciService _kullaniciService;
        public YetenekTemsilcisiListeModel(IKullaniciService kullaniciService)
        {
            _kullaniciService = kullaniciService;
        }
		public async Task<IActionResult> OnGetAsync()
        {
            OdiResult res = await _kullaniciService.KullaniciListesiGetir();

            return Content(JsonConvert.SerializeObject(res));
        }
		
	}
}
