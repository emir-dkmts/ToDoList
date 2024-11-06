using Microsoft.Extensions.DependencyInjection;
using ToDo.Service.Abstracts;
using ToDo.Service.Concretes;
using ToDo.Service.Rules;

namespace ToDo.Service;

public static class ServiceDependencies
{
    public static IServiceCollection AddServiceDependencies(this IServiceCollection services)
    {
        services.AddScoped<ToDoBusinessRules>();
        services.AddScoped<IJwtService, JwtService>();
        services.AddScoped<IAuthenticationService, AuthenticationService>();
        services.AddScoped<IUserService, UserService>();
        services.AddScoped<IToDoService, ToDoService>();
        services.AddScoped<ICategoryService, CategoryService>();

        return services;
    }
}
