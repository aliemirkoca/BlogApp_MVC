using System.ComponentModel.DataAnnotations;

namespace BlogApp.Models
{
    public class LoginViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = " EPosta")]
        public string? Email { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Maks 10 karakter belirtiniz!")]
        [DataType(DataType.Password)]
        [Display(Name = "Parola")]
        public string? Password { get; set; }

    }
}