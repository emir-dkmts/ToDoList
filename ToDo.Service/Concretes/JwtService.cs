using Core.Tokens.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Options;
using ToDo.Models.Dtos.Tokens.Responses;
using ToDo.Models.Entities;
using ToDo.Service.Abstracts;

namespace ToDo.Service.Concretes;

public sealed class JwtService : IJwtService
{
    private readonly TokenOption _tokenOption;
    private readonly UserManager<User> _userManager;

    public JwtService(IOptions<TokenOption> tokenOption, UserManager<User> userManager)
    {
        _tokenOption = tokenOption.Value;
        _userManager = userManager;
    }
    public Task<TokenResponseDto> CreateJwtTokenAsync(User user)
    {
        throw new NotImplementedException();
    }
}
