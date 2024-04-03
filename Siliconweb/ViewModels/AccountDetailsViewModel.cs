using Siliconweb.Models;

namespace Siliconweb.ViewModels;

public class AccountDetailsViewModel
{
    public string Title { get; set; } = "Account Details";
    public AccountDetailsBasicInfoModel BasicInfo { get; set; } = new AccountDetailsBasicInfoModel();
    public AccountDetailsAdressInfoModel AddressInfo { get; set; } = new AccountDetailsAdressInfoModel();
}
