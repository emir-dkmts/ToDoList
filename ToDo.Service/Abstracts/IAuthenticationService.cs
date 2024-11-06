using Core.Responses;
using ToDo.Models.Dtos.Tokens.Responses;
using ToDo.Models.Dtos.User.Request;

namespace ToDo.Service.Abstracts;

public interface IAuthenticationService
{
    Task<ReturnModel<TokenResponseDto>> LoginAsync(UserLoginRequestDto loginRequestDto);
    Task<ReturnModel<TokenResponseDto>> RegisterAsync(UserRegisterRequestDto registerRequestDto);
}
