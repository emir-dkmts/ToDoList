using Microsoft.AspNetCore.Identity;
using ToDo.Models.Dtos.User.Request;
using ToDo.Models.Entities;
using ToDo.Service.Abstracts;

namespace ToDo.Service.Concretes;

public sealed class UserService(UserManager<User> _userManager) : IUserService
{
    public Task<User> ChangePasswordAsync(string id, UserChangePasswordRequest changePasswordRequestDto)
    {
        throw new NotImplementedException();
    }

    public Task<string> DeleteAsync(string id)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetByEmailAsync(string email)
    {
        throw new NotImplementedException();
    }

    public Task<User> LoginAsync(UserLoginRequestDto loginRequestDto)
    {
        throw new NotImplementedException();
    }

    public Task<User> RegisterAsync(UserRegisterRequestDto registerDto)
    {
        throw new NotImplementedException();
    }

    public Task<User> UpdateAsync(string id, UserUpdateRequest updateDto)
    {
        throw new NotImplementedException();
    }
    private void CheckForIdentityResult(IdentityResult result)
    {
        if (!result.Succeeded)
        {
            throw new(result.Errors.ToList().First().Description);
        }
    }
}
