namespace ToDo.Models.Dtos.User.Request;

public sealed record UserChangePasswordRequest
    (
        string CurrentPassword,
        string NewPassword,
        string NewPasswordAgain
    );