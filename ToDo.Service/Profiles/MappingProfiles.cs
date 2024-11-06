using AutoMapper;
using ToDo.Models.Dtos.Category.Request;
using ToDo.Models.Dtos.Category.Response;
using ToDo.Models.Dtos.ToDo.Request;
using ToDo.Models.Dtos.ToDo.Response;
using ToDo.Models.Dtos.User.Response;
using ToDo.Models.Entities;

namespace ToDo.Service.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<CreateToDoRequest, ToDo.Models.Entities.ToDo>();
        CreateMap<UpdateToDoRequest, ToDo.Models.Entities.ToDo>();
        CreateMap<ToDo.Models.Entities.ToDo, ToDoResponseDto>()
            .ForMember(x => x.Category, opt => opt.MapFrom(x => x.Category.Name))
            .ForMember(x => x.UserName, opt => opt.MapFrom(x => x.User.UserName));

        CreateMap<CreateCategoryRequest, Category>();
        CreateMap<UpdateCategoryRequest, Category>();
        CreateMap<Category, CategoryResponseDto>();

        CreateMap<User, UserResponseDto>();
    }
}
