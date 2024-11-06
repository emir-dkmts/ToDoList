using Core.Responses;
using ToDo.Models.Dtos.Tokens.Responses;
using ToDo.Models.Dtos.User.Request;
using ToDo.Service.Abstracts;

namespace ToDo.Service.Concretes
{
    public class AuthenticationService(IUserService _userService, IJwtService _jwtService) : IAuthenticationService
    {
        public Task<ReturnModel<TokenResponseDto>> LoginAsync(UserLoginRequestDto loginRequestDto)
        {
            throw new NotImplementedException();
        }

        public Task<ReturnModel<TokenResponseDto>> RegisterAsync(UserRegisterRequestDto registerRequestDto)
        {
            throw new NotImplementedException();
        }
    }
}
