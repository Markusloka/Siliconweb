using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Siliconweb.Models;

public class AccountDetailsBasicInfoModel
{
    [DataType(DataType.ImageUrl)]
    public string? ProfileImage { get; set; }

    [Display(Name = "First name", Prompt = "Enter your first name", Order = 0)]
    [Required(ErrorMessage = "Invalid first name")]

    public string FirstName { get; set; } = null!;

    [Display(Name = "Last name", Prompt = "Enter your last name", Order = 1)]
    [Required(ErrorMessage = "Invalid first name")]

    public string LastName { get; set; } = null!;

    [DataType(DataType.EmailAddress)]
    [Display(Name = "Email", Prompt = "Enter your email", Order = 3)]
    [Required(ErrorMessage = "Invalid email")]
    [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter a valid e-mail adress")]

    public string Email { get; set; } = null!;

   
    [Display(Name = "Phone", Prompt = "Enter your phone", Order = 4)]
    [DataType(DataType.PhoneNumber)]
    [Required(ErrorMessage = "Phone is required")]
    public string Phone { get; set; } = null!;

    [Display(Name = "Bio", Prompt = "Add a short bio...", Order = 5)]
    [DataType(DataType.MultilineText)]
    public string? Biography { get; set; }
}
