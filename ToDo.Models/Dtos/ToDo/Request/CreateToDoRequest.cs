namespace ToDo.Models.Dtos.ToDo.Request;

public sealed record CreateToDoRequest
    (
        string Title,
        string Description,
        int CategoryId
    );