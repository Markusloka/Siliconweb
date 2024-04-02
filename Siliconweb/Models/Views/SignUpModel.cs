using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Siliconweb.Helpers;
using Siliconweb.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace Siliconweb.Models.Views;

public class SignUpModel
{
    [Display(Name = "First name", Prompt = "Enter your first name", Order = 0)]
    [Required(ErrorMessage = "Invalid first name")]

    public string FirstName { get; set; } = null!;
    
    [Display(Name = "Last name", Prompt = "Enter your last name", Order = 1)]
    [Required(ErrorMessage = "Invalid first name")]

    public string LastName { get; set; } = null!;
    
    [DataType(DataType.EmailAddress)]
    [Display(Name = "Email", Prompt = "Enter your email", Order = 2)]
    [Required(ErrorMessage = "Invalid email")]
    [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid e-mail adress")]


    public string Email { get; set; } = null!;
    
    [Display(Name = "Password", Prompt = "Enter your password", Order = 3)]
    [Required(ErrorMessage = "Invalid Password")]
    [DataType(DataType.Password)]
    [RegularExpression("^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[@$!%*?&])[A-Za-z\\d@$!%*?&]{8,}$", 
        ErrorMessage = "Password must contain at least 8 characters, including at least one lowercase letter, one uppercase letter, one digit, and one special character.")]
    public string Password { get; set; } = null!;

    
    [Display(Name = "Confirm password", Prompt = "Confirm your password", Order = 4)]
    [Required(ErrorMessage = "Password must be confirmed")]
    [DataType(DataType.Password)]
    [Compare(nameof(Password), ErrorMessage = "Password does not match")]
    public string ConfirmPassword { get; set; } = null!;
    
    
    [Display(Name = "I agree to the terms & conditions.", Order = 5)]
    [CheckBoxRequired(ErrorMessage = "You must accept the terms and conditions")]


    public bool TermsAndConditions { get; set; } = false;
}



    