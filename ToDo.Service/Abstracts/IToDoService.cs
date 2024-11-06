using Core.Responses;
using ToDo.Models.Dtos.ToDo.Request;
using ToDo.Models.Dtos.ToDo.Response;

namespace ToDo.Service.Abstracts;

public interface IToDoService
{
    Task<ReturnModel<List<ToDoResponseDto>>> GetAllAsync();
    Task<ReturnModel<ToDoResponseDto>> GetByIdAsync(Guid id);
    Task<ReturnModel<ToDoResponseDto>> AddAsync(CreateToDoRequest createToDoRequest);
    Task<ReturnModel<ToDoResponseDto>> UpdateAsync(UpdateToDoRequest updateToDoRequest);
    Task<ReturnModel<ToDoResponseDto>> RemoveAsync(Guid id);
}
