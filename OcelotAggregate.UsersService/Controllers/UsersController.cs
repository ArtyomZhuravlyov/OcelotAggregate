using Microsoft.AspNetCore.Mvc;

namespace OcelotAggregate.UsersService.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    [HttpGet("{id:int}")]
    public User? GetById(int id)
    {

        var users = new User[] { new User() { Id = 1, Name = "Artem" }, new User() { Id = 2, Name = "Ivan" } };
        return users.SingleOrDefault(x => x.Id == id);
    }
}