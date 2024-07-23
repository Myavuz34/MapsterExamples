using MapsterExamples.Models;

namespace MapsterExamples.Services;

public interface IUserService
{
    IEnumerable<User> GetUsers();
}