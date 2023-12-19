using System.ComponentModel.DataAnnotations;

namespace RA.AspNetCoreMVC.Models.ViewModels
{
    public class LoginVM
    {
        [Required(ErrorMessage = "(Kullanıcı Adı Boş Geçilemez!)")]
        [Display(Name = "Kullanıcı Adı :")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "(Şifre Boş Geçilemez!)")]
        [Display(Name ="Şifre :")]
        public string Password { get; set; }
    }
}
