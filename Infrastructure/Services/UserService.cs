using Azure;
using Infrastructure.Factories;
using Infrastructure.Models;
using Infrastructure.Repositories;

namespace Infrastructure.Services;

public class UserService (UserRepository repository, AddressService addressService)
{
    private readonly UserRepository _repository;
    private readonly AddressService _addressService;


    public async Task<ResponseResult> CreateUserAsync (SignUpModel model)
    {
		try
		{
			var result = await _repository.AlreadyExistAsync(x => x.Email == model.Email);
			if(result.StatusCode != StatusCode.EXISTS)
			{
				result = await _repository.CreateOneAsync(UserFactory.Create(model));
				if (result.StatusCode != StatusCode.OK)
					return ResponseFactory.Ok("User was created successfully");

				return result;
			}
			return result;
		}
		catch (Exception ex)
		{
			return ResponseFactory.Error(ex.Message);
		}
    }
}
