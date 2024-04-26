using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdiAdmin.Models;
using OdiAdmin.Models.AccountModels;
using OdiAdmin.Services.Identity;
using System.Text.Json;

namespace OdiAdmin.Pages.Account
{
	public class LoginModel : PageModel
    {
		[BindProperty]
        public SignInInput signInInput { get; set; }


		IIdentityService _identityService;
		public LoginModel(IIdentityService identityService)
		{
			_identityService = identityService;
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
			res.Mesaj = "Dashboard a yönlendiriliyorsunuz";

			return Content(JsonSerializer.Serialize(res));
        }

	}
}
