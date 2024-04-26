using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdiAdmin.Models;
using OdiAdmin.Services.OdiUsers;
using OdiAdmin.Services.UygulamaAyarlari;

namespace OdiAdmin.Pages.UygulamaAyarlari.Diller
{
    public class DilListesiModel : PageModel
    {
        IOdiUserService _service;
        public DilListesiModel(IOdiUserService service) { 
        _service    = service;
        }
        public async void OnGet()
        {
            OdiUser user = await _service.GetUser();
        }
    }
}
