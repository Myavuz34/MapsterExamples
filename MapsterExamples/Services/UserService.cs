using MapsterExamples.Models;

namespace MapsterExamples.Services;

public class UserService : IUserService
{
    public IEnumerable<User> GetUsers()
    {
        return new List<User>
        {
            new() { Id = 1, Name = "Mustafa Yavuz", Email = "mustafa.yavuz@example.com" },
            new() { Id = 2, Name = "Mustafa", Email = "mustafa@example.com" }
        };
    }
}