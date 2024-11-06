using Core.Repositories;
using ToDo.Models.Entities;

namespace ToDo.DataAccess.Abstracts;

public interface IToDoRepository : IRepository<ToDo.Models.Entities.ToDo, Guid>
{
}