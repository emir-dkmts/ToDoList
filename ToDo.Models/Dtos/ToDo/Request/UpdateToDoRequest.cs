namespace ToDo.Models.Dtos.ToDo.Request;

public sealed record UpdateToDoRequest
    (
        Guid Id,
        string Title,
        string Description
    );