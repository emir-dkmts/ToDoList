using Core.Repositories;
using ToDo.Models.Entities;

namespace ToDo.DataAccess.Abstracts;

public interface ICategoryRepository : IRepository<Category, int>
{
}
