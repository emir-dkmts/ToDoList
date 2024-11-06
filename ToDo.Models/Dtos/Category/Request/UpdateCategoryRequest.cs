namespace ToDo.Models.Dtos.Category.Request;

public sealed record UpdateCategoryRequest
    (
        int Id,
        string Name
    );
