using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdiAdmin.Models;
using OdiAdmin.Models.UygulamaAyarlari;
using OdiAdmin.Services.OdiUsers;
using OdiAdmin.Services.UygulamaAyarlari;

namespace OdiAdmin.Pages.UygulamaAyarlari.Diller
{
    [Authorize]
    public class DilListesiModel : PageModel
    {
        IDilService _service;
        [BindProperty]
		public List<Dil> dilListesi { get; set; } =new List<Dil>();

		public DilListesiModel(IDilService service) { 
        _service    = service;
        }
        public async void OnGet()
        {
            ApiResponse<List<Dil>> res = await _service.DilListesiAsyc();
            dilListesi = res.Data as List<Dil>;

        }
    }
}
