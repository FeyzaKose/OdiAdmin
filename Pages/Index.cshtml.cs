using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using OdiAdmin.Models;
using OdiAdmin.Services.OdiUsers;

namespace OdiAdmin.Pages
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        
        [BindProperty]
        public OdiUser odiUser { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            
        }

        public async void OnGet()
        {
           
        }
    }
}
