using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;

using Microsoft.AspNetCore.Mvc;
using ToDo.Models.Dtos.User.Request;

namespace ToDoAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationController : CustomBaseController
{
    private readonly ToDo.Service.Abstracts.IAuthenticationService authenticationService;

    public AuthenticationController(ToDo.Service.Abstracts.IAuthenticationService authenticationService)
    {
        authenticationService = authenticationService;
    }

    [HttpPost("login")]
    public async Task<IActionResult> Login([FromBody] UserLoginRequestDto dto)
    {
        var result = await authenticationService.LoginAsync(dto);
        return Ok(result);
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register([FromBody] UserRegisterRequestDto dto)
    {
        var result = await authenticationService.RegisterAsync(dto);
        return Ok(result);
    }
}