using Core.Responses;
using ToDo.Models.Dtos.Category.Request;
using ToDo.Models.Dtos.Category.Response;

namespace ToDo.Service.Abstracts;

public interface ICategoryService
{
    Task<ReturnModel<List<CategoryResponseDto>>> GetAllAsync();
    Task<ReturnModel<CategoryResponseDto>> GetByIdAsync(int id);
    Task<ReturnModel<CategoryResponseDto>> AddAsync(CreateCategoryRequest createCategoryRequest);
    Task<ReturnModel<CategoryResponseDto>> UpdateAsync(UpdateCategoryRequest updateCategoryRequest);
    Task<ReturnModel<CategoryResponseDto>> RemoveAsync(int id);
}
