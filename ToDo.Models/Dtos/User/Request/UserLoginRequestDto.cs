namespace ToDo.Models.Dtos.User.Request;

public sealed record UserLoginRequestDto
    (
        string Email,
        string Password
    );