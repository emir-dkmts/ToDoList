using Core.Repositories;
using ToDo.DataAccess.Abstracts;
using ToDo.DataAccess.Contexts;
using ToDo.Models.Entities;

namespace ToDo.DataAccess.Concretes;

public class EfCategoryRepository : EfRepositoryBase<BaseDbContext, Category, int>, ICategoryRepository
{
    public EfCategoryRepository(BaseDbContext context) : base(context)
    {
    }
}
