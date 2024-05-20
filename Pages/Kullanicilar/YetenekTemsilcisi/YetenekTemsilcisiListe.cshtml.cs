using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Newtonsoft.Json;
using OdiAdmin.Handler;
using OdiAdmin.Models;
using OdiAdmin.Services.KullaniciServices;
using OdiAdmin.Extensions;
namespace OdiAdmin.Pages.Kullanicilar.YetenekTemsilcisi
{
    [Authorize]
    public class YetenekTemsilcisiListeModel : PageModel
    {
        [BindProperty]
       public List<Kullanici> YetenekTemsilcileri { get; set; }


        private readonly IKullaniciService _kullaniciService;
        public YetenekTemsilcisiListeModel(IKullaniciService kullaniciService)
        {
            _kullaniciService = kullaniciService;
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
