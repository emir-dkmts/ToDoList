using AutoMapper;
using Core.Responses;
using Microsoft.AspNetCore.Identity;
using ToDo.DataAccess.Abstracts;
using ToDo.Models.Dtos.ToDo.Request;
using ToDo.Models.Dtos.ToDo.Response;
using ToDo.Service.Abstracts;
using ToDo.Service.Rules;

namespace ToDo.Service.Concretes
{
    public sealed class ToDoService : IToDoService
    {
        private readonly IToDoRepository _toDoRepository;
        private readonly IMapper _mapper;
        private readonly ToDoBusinessRules _toDoBusinessRules;

        public ToDoService(IToDoRepository toDoRepository, IMapper mapper, ToDoBusinessRules toDoBusinessRules)
        {
            _toDoRepository = toDoRepository;
            _mapper = mapper;
            _toDoBusinessRules = toDoBusinessRules;
        }
        public Task<ReturnModel<ToDoResponseDto>> AddAsync(CreateToDoRequest createToDoRequest)
        {
            throw new NotImplementedException();
        }

        public Task<ReturnModel<List<ToDoResponseDto>>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<ReturnModel<ToDoResponseDto>> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ReturnModel<ToDoResponseDto>> RemoveAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ReturnModel<ToDoResponseDto>> UpdateAsync(UpdateToDoRequest updateToDoRequest)
        {
            throw new NotImplementedException();
        }
     
    }
}
