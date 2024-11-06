using Core.Exceptions;
using ToDo.Models.Entities;

namespace ToDo.Service.Rules;

public class ToDoBusinessRules
{
    public virtual void ToDoIsNullCheck(ToDo.Models.Entities.ToDo toDo)
    {
        if(toDo == null)
        {
            throw new NotFoundExceptions("İlgili yapılacak iş bulunamadı.");
        }
    }
}
