using System.ComponentModel.DataAnnotations;

namespace DoyDoyWebApp.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Email alanı zorunludur.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre alanı zorunludur.")]
        [MinLength(8, ErrorMessage = "Şifreniz minimum 8 karakter olmalıdır.")]
        [RegularExpression("\\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,7}\\b", ErrorMessage = "Geçersiz email girdiniz.")]
        public string Password { get; set; }
    }
}
