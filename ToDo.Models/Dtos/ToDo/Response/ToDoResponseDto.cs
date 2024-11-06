using ToDo.Models.Entities;

namespace ToDo.Models.Dtos.ToDo.Response;

public sealed record ToDoResponseDto
{
    public Guid Id { get; init; }
    public string Title { get; init; }
    public string Description { get; init; }
    public DateTime StartDate { get; init; }
    public DateTime EndDate { get; init; }
    public string Priority{ get; init; }
    public bool Completed { get; init; }
    public string UserName { get; set; }
    public string Category { get; init; }
}