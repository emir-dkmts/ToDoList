namespace ToDo.Models.Dtos.User.Request;

public sealed record UserUpdateRequest
    (
        string FirstName,
        string LastName,
        string City,
        string UserName
    );