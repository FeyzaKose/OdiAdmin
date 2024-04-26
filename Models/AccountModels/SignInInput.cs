using System.ComponentModel.DataAnnotations;

namespace OdiAdmin.Models.AccountModels
{
    public class SignInInput
    {
        [Display(Name ="Telefon Numarası")]
        [Required]
        public string Telefon { get; set; }

        [Display(Name = "Şifre")]
        [Required]
        public string Sifre { get; set; }

        [Display(Name ="Beni Hatırla")]
        public bool BeniHatirla { get; set; }
    }
}
