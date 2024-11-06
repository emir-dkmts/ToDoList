using Core.Repositories;
using ToDo.DataAccess.Abstracts;
using ToDo.DataAccess.Contexts;
using ToDo.Models.Entities;

namespace ToDo.DataAccess.Concretes;

public class EfToDoRepository : EfRepositoryBase<BaseDbContext, ToDo.Models.Entities.ToDo, Guid>, IToDoRepository
{
    public EfToDoRepository(BaseDbContext context) : base(context)
    {
    }
}
