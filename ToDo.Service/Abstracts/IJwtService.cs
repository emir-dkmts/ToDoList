using ToDo.Models.Dtos.Tokens.Responses;
using ToDo.Models.Entities;

namespace ToDo.Service.Abstracts;

public interface IJwtService
{
    Task<TokenResponseDto> CreateJwtTokenAsync(User user);
}
