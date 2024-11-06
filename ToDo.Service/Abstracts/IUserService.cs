using Core.Responses;
using ToDo.Models.Dtos.User.Request;
using ToDo.Models.Dtos.User.Response;
using ToDo.Models.Entities;

namespace ToDo.Service.Abstracts;

public interface IUserService
{
    Task<User> RegisterAsync(UserRegisterRequestDto registerDto);
    Task<User> GetByEmailAsync(string email);
    Task<User> LoginAsync(UserLoginRequestDto loginRequestDto);
    Task<User> UpdateAsync(string id, UserUpdateRequest updateDto);
    Task<string> DeleteAsync(string id);
    Task<User> ChangePasswordAsync(string id, UserChangePasswordRequest changePasswordRequestDto);
}
