using System.ComponentModel.DataAnnotations;

namespace DoyDoyWebApp.Models
{
    public class SignupModel
    {
        [Required(ErrorMessage = "İsim alanı zorunludur.")]
        [MaxLength(100, ErrorMessage ="İsim maksimum 100 karakter olmalıdır.")]
        [MinLength(2,ErrorMessage ="İsim minimum 2 karakter olmalıdır.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Soyisim alanı zorunludur.")]
        [MaxLength(100, ErrorMessage = "Soyisim maksimum 100 karakter olmalıdır.")]
        [MinLength(2,ErrorMessage ="Soyisim minimum 2 karakter olmalıdır.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Email alanı zorunludur.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Şifre alanı zorunludur.")]
        [MinLength(8, ErrorMessage = "Şifreniz minimum 8 karakter olmalıdır.")]
        [RegularExpression("\\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\\.[A-Za-z]{2,7}\\b",ErrorMessage ="Geçersiz email girdiniz.")]
        public string Password { get; set; }
    }
}