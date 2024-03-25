namespace Siliconweb.Models.Views;

public class SignInViewModel
{
    public string Title { get; set; } = "Sign in";
    public SignInModel Form { get; set; } = new SignInModel();

    public bool RememberMe { get; set; } = false;
}