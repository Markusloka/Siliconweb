using System.ComponentModel.DataAnnotations;

namespace Siliconweb.Models
{
    public class AccountDetailsAdressInfoModel
    {
        [Display(Name = "Address line", Prompt = "Home address", Order = 0)]
        [Required(ErrorMessage = "Invalid address")]

        public string Addressline_1 { get; set; } = null!;

        [Display(Name = "Secound Address line", Prompt = "Secoundary Address", Order = 1)]

        public string? Addressline_2 { get; set; }


        [Display(Name = "Postal Code", Prompt = "Enter your Postal Code", Order = 2)]
        [Required(ErrorMessage = "Invalid postal code")]
        [DataType(DataType.PostalCode)]
        public string PostalCode { get; set; } = null!;

        [Display(Name = "City", Prompt = "Enter your City", Order = 3)]
        [Required(ErrorMessage = "City is required")]
    

        public string City { get; set; } = null!;
    }
}
