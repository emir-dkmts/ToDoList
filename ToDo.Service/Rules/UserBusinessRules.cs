using Core.Exceptions;
using Microsoft.AspNetCore.Identity;
using ToDo.Models.Entities;

namespace ToDo.Service.Rules;

public class UserBusinessRules(UserManager<User> userManager)
{
    public async Task CheckIfEmailIsUniqueAsync(string email)
    {
        var existingUser = await userManager.FindByEmailAsync(email);
        if (existingUser != null)
        {
            throw new BusinessExceptions("Bu mail adresi zaten alınmış!");
        }
    }

    public void CheckIfPasswordIsStrong(string password)
    {
        var hasUpperCase = password.Any(char.IsUpper);
        var hasDigit = password.Any(char.IsDigit);
        var hasSpecialChar = password.Any(ch => !char.IsLetterOrDigit(ch));

        if (!(hasUpperCase && hasDigit && hasSpecialChar))
        {
            throw new BusinessExceptions("Parola en az bir büyük harf, bir rakam ve bir özel karakter içermelidir.");
        }
    }

}
