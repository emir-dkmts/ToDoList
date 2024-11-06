using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using ToDo.DataAccess.Abstracts;
using ToDo.DataAccess.Concretes;
using ToDo.DataAccess.Contexts;
using ToDo.Models.Entities;

namespace ToDo.DataAccess;

public static class DataAccessRepositoryDependencies
{
    public static IServiceCollection AddDataAccessDependencies(this IServiceCollection services, IConfiguration configurations)
    {
        services.AddScoped<IToDoRepository, EfToDoRepository>();
        services.AddScoped<ICategoryRepository, EfCategoryRepository>();

        services.AddDbContext<BaseDbContext>(opt => opt.UseSqlServer(configurations.GetConnectionString("SqlConnection")));

        return services;
    }
}
