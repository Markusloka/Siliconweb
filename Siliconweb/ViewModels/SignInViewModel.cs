using Siliconweb.Models.Views;

namespace Siliconweb.ViewModels;

public class SignInViewModel
{
    public string Title { get; set; } = "Sign in";
    public SignInModel Form { get; set; } = new SignInModel();

    public bool RememberMe { get; set; } = false;
    public string? ErrorMessage { get; set; }

}