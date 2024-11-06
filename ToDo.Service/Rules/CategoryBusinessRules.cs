using Core.Exceptions;
using ToDo.DataAccess.Abstracts;

namespace ToDo.Service.Rules;

public class CategoryBusinessRules(ICategoryRepository categoryRepository)
{
    public void CheckIfCategoryNameIsValid(string categoryName)
    {
        if (categoryName.Length < 3 || categoryName.Length > 20)
        {
            throw new BusinessExceptions("Kategori adı en az 3 en fazla 20 olmalıdır");
        }
    }
}