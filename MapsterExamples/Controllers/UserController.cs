using Mapster;
using MapsterExamples.Dtos;
using MapsterExamples.Services;
using Microsoft.AspNetCore.Mvc;

namespace MapsterExamples.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController(IUserService userService) : ControllerBase
{
   [HttpGet]
   public ActionResult<IEnumerable<UserDto>> GetUsers()
   {
      var users = userService.GetUsers();
      var userDtos = users.Adapt<IEnumerable<UserDto>>();
      return Ok(userDtos);
   }
}