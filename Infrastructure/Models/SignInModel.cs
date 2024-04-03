using System.ComponentModel.DataAnnotations;

namespace Infrastructure.Models;

public class SignInModel
{
    [DataType(DataType.EmailAddress)]
    [Display(Name = "Email", Prompt = "Enter your email", Order = 0)]
    [Required(ErrorMessage = "Invalid email")]

    public string Email { get; set; } = null!;

    [Display(Name = "Password", Prompt = "Enter your password", Order = 1)]
    [Required(ErrorMessage = "Invalid Password")]
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;

    [Display(Name = "Remember Me", Order = 2)]
    public bool RememberMe { get; set; }
}
