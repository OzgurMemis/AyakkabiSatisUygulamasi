using System.ComponentModel.DataAnnotations;

namespace AyakkabiSatisUygulamasi.Dto
{
    public class AppUserRegisterDto
    {
        [Display(Name ="Adınız")]
        [Required(ErrorMessage ="Adınızı Boş Geçemezsiniz")]
        public string FirstName { get; set; }
        [Display(Name = "Soyadınız")]
        [Required(ErrorMessage = "Soyadınızı Boş Geçemezsiniz")]
        public string LastName { get; set; }
        [Display(Name = "Kullanıcı Adını Giriniz")]
        [Required(ErrorMessage = "Kullanıcı Adınızı Boş Geçemezsiniz")]
        public string UserName { get; set; }
        [Display(Name = "Şehir")]
        [Required(ErrorMessage = "Şehrinizi Boş Geçemezsiniz")]
        public string City { get; set; }
        [Display(Name = "E-Posta Adresiniz")]
        [Required(ErrorMessage = "E-Posta Adresinizi Boş Geçemezsiniz")]
        public string Email { get; set; }
        [Display(Name = "Telefon Numarası")]
        [Required(ErrorMessage = "Telefon Numarasını Boş Geçemezsiniz")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Şifreniz")]
        [Required(ErrorMessage = "Şifrenizi Boş Geçemezsiniz")]
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
