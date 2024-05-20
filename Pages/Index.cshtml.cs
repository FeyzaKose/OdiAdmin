using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdiAdmin.Models;
using OdiAdmin.Models.UygulamaAyarlari;
using OdiAdmin.Services.OdiUsers;
using OdiAdmin.Services.UygulamaAyarlari;
using System.Text.Json;

namespace OdiAdmin.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
     
        IDilService _dilService;
        
        [BindProperty]
        public OdiUser odiUser { get; set; }
        public IndexModel( IDilService dilService)
        {

            _dilService = dilService;
            
        }
        [BindProperty]
        public List<Dil> dilListesi { get; set; }
        public async Task OnGet()
        {
            dilListesi = await _dilService.SessionDilListesiAsyc();
        }


        #region Diğer Sayfaların Fonksiyonları
        #region Dil Servisleri
        public async Task<IActionResult> OnGetDilListesiAsync()
        {

            dilListesi = await _dilService.SessionDilListesiAsyc();
            OdiResult res = new OdiResult { Sonuc = true, Data = dilListesi, Mesaj = "Dil listesi getirildi" };
            return Content(JsonSerializer.Serialize(res));
        }
        #endregion

        #region UygulamaBilgiler
        #region FizikselOzellikler

        #endregion

        #endregion

        #endregion
    }
}
