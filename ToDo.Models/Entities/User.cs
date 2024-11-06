using Microsoft.AspNetCore.Identity;

namespace ToDo.Models.Entities;

public class User : IdentityUser
{
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public DateTime BirthDate { get; set; }
    public string City { get; set; }
    public List<ToDo> ToDos { get; set; }
}
