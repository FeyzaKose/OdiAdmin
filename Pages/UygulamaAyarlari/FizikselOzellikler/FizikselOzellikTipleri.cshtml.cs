using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdiAdmin.Models;
using OdiAdmin.Models.UygulamaAyarlari;
using OdiAdmin.Services.UygulamaAyarlari;
using OdiAdmin.Services.UygulamaAyarlari.FizikselOzellikler;
using System.Text.Json;

namespace OdiAdmin.Pages.UygulamaAyarlari.FizikselOzellikler
{
    [Authorize]
    [IgnoreAntiforgeryToken]
    public class FizikselOzellikTipleriModel : PageModel
    {
        IDilService _dilService;
        IFizikselOzellikService _fiziselOzellikService;

        public FizikselOzellikTipleriModel(IDilService dilService, IFizikselOzellikService fiziselOzellikService)
        {
            _dilService = dilService;
            _fiziselOzellikService = fiziselOzellikService;
        }

        public List<Dil> dilListesi { get; set; }
        public List<FizikselOzellikTipi> tipListesi { get; set; }
        public async Task OnGet()
        {
            
        }

       
        public async Task<IActionResult> OnPostDilListesiAsync()
        {

            dilListesi = await _dilService.SessionDilListesiAsyc();
            OdiResult res = new OdiResult { Sonuc = true,Data= dilListesi };     
            return Content(JsonSerializer.Serialize(res));
        }
        public async Task<IActionResult> OnPostFizikselOzellikListesiGetirAsync([FromBody]PostDil dil)
        {
            
            ApiResponse<List< FizikselOzellikTipi >> resp = await _fiziselOzellikService.FizikselOzellikTipiListe(dil.DilId);
            OdiResult res = new OdiResult { Sonuc = true, Data = resp.Data };
            return Content(JsonSerializer.Serialize(res));
        } 
        public async Task<IActionResult> OnPostYeniFizikselOzellikAsync([FromBody] FizikselOzellikTipi tip)
        {
            ApiResponse<List<FizikselOzellikTipi>> resp = await _fiziselOzellikService.YeniFizikselOzellikTipi(tip);
            OdiResult res = new OdiResult { Sonuc = true, Data = resp.Data };
            return Content(JsonSerializer.Serialize(res));
        }
        public async Task<IActionResult> OnPostFizikselOzellikGuncelleAsync([FromBody] FizikselOzellikTipi tip)
        {
            ApiResponse<List<FizikselOzellikTipi>> resp = await _fiziselOzellikService.FizikselOzellikTipiGuncelle(tip);
            OdiResult res = new OdiResult { Sonuc = true, Data = resp.Data };
            return Content(JsonSerializer.Serialize(res));
        }
        public class PostDil
        {
            public int DilId { get; set; }
        }
    }
    

}
