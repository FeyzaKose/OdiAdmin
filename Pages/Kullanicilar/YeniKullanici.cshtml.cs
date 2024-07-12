using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdiAdmin.Models.PartialViewModels.Kullanicilar;

namespace OdiAdmin.Pages.Kullanicilar
{
    public class YeniKullaniciModel : PageModel
    {
        [BindProperty]
        public YeniKullaniciViewModel ViewModal { get; set; }
        public void OnGet()
        {
            ViewModal = new YeniKullaniciViewModel { SayfaBasligi = "Yeni Kullanýcý" };


        }
    }
}
