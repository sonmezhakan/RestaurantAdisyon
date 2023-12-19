using System.ComponentModel.DataAnnotations;

namespace RA.AspNetCoreMVC.Models.ViewModels
{
    public class RegisterVM
    {
        [Required(ErrorMessage = "(Kullanıcı Adı Boş Geçilemez!)")]
        [Display(Name = "Kullanıcı Adı :")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "(Şifre Boş Geçilemez!)")]
        [Display(Name = "Şifre  :")]
        public string Password { get; set; }

        [Required(ErrorMessage = "(Şifre(tekrar) Boş Geçilemez!)")]
        [Display(Name = "Şifre (tekrar) :")]
        [Compare("Password",ErrorMessage ="(Şifreler Eşleşmiyor!)")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "( Ad Boş Geçilemez!)")]
        [Display(Name = " Ad :")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "(Soyad Boş Geçilemez!)")]
        [Display(Name = "Soyad :")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "(Email Boş Geçilemez!)")]
        [Display(Name = "Email :")]
        [EmailAddress(ErrorMessage = "(Lütfen Email Formatında Değer Giriniz!)")]
        public string Email { get; set; }

        [Required(ErrorMessage = "(Telefon Numarası Boş Geçilemez!)")]
        [Display(Name = "Telefon Numarası :")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "(Adres Boş Geçilemez!)")]
        [Display(Name = "Adres :")]
        public string Adress { get; set; }

        [Display(Name = "Durum")]
        public bool? IsActive { get { return true; } }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
