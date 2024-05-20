using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdiAdmin.Extensions;
using OdiAdmin.Models;
using OdiAdmin.Models.AccountModels;
using OdiAdmin.Models.UygulamaAyarlari;
using OdiAdmin.Services.Identity;
using OdiAdmin.Services.UygulamaAyarlari;
using System.Text.Json;

namespace OdiAdmin.Pages.Account
{
	public class LoginModel : PageModel
    {
		[BindProperty]
        public SignInInput signInInput { get; set; }


		IIdentityService _identityService;
		IDilService _dilservice;
		public LoginModel(IIdentityService identityService,IDilService dilService)
		{
			_identityService = identityService;
			_dilservice = dilService;
		}


		public void OnGet()
        {
        }
		public async Task<IActionResult> OnPostAsync()
        {
			OdiResult res =new OdiResult();

			if (!ModelState.IsValid)
			{
				List<string> errors = ModelState.Values
			 .SelectMany(v => v.Errors)
			 .Select(e => e.ErrorMessage)
			 .ToList();
				res.Sonuc = false;
				res.Mesaj = JsonSerializer.Serialize(errors);
				return Content(JsonSerializer.Serialize(res));

			}
			signInInput.Telefon = "9" + signInInput.Telefon.Trim().Replace(" ", "").Replace("(", "").Replace(")", "");
			var response = await _identityService.SignIn(signInInput);
			if (!response.IsSuccessful)
			{
				List<string> errors = response.Errors.ToList();									 
				res.Sonuc = false;
				res.Mesaj = JsonSerializer.Serialize(errors); ;
				return Content(JsonSerializer.Serialize(res));
			}

			res.Sonuc = true;

			 ////List<Dil> dilList = await _dilservice.SessionDilListesiAsyc();
    //        HttpContext.Session.SetObject("LanguageList", dilList);

            res.Mesaj = "Dashboard a yönlendiriliyorsunuz"; 

			return Content(JsonSerializer.Serialize(res));
        }

	}
}
