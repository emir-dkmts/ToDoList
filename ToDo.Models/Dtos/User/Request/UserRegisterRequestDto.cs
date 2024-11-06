namespace ToDo.Models.Dtos.User.Request;

public sealed record UserRegisterRequestDto
    (
        string FirstName,
        string LastName,
        string Email,
        string Password,
        string UserName,
        string City
    );
