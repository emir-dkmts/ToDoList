using AutoMapper;
using Core.Responses;
using ToDo.DataAccess.Abstracts;
using ToDo.Models.Dtos.Category.Request;
using ToDo.Models.Dtos.Category.Response;
using ToDo.Service.Abstracts;

namespace ToDo.Service.Concretes
{
    public sealed class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public Task<ReturnModel<CategoryResponseDto>> AddAsync(CreateCategoryRequest createCategoryRequest)
        {
            throw new NotImplementedException();
        }

        public Task<ReturnModel<List<CategoryResponseDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ReturnModel<CategoryResponseDto>> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ReturnModel<CategoryResponseDto>> RemoveAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ReturnModel<CategoryResponseDto>> UpdateAsync(UpdateCategoryRequest updateCategoryRequest)
        {
            throw new NotImplementedException();
        }
    }
}
