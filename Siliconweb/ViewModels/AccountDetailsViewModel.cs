using Siliconweb.Models;

namespace Siliconweb.ViewModels;

public class AccountDetailsViewModel
{
    public string Title { get; set; } = "Account Details";
    public AccountDetailsBasicInfoModel BasicInfo { get; set; } = new AccountDetailsBasicInfoModel()
    { 
        ProfileImage = "images/profile-image.svg",
        FirstName = "Markus",
        LastName = "Lokander",
        Email = "Markuslokander97@gmail.com",
    
    };
    public AccountDetailsAdressInfoModel AddressInfo { get; set; } = new AccountDetailsAdressInfoModel();
}
