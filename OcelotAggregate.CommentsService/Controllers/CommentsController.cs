using Microsoft.AspNetCore.Mvc;
using OcelotAggregate.CommentsService;

namespace OcelotAggregate.CommentsService.Controllers;

[ApiController]
[Route("[controller]")]
public class CommentsController : ControllerBase
{
    [HttpGet]
    public Comment[] GetAll()
    {
        return new Comment[] { new Comment() { Id = 1, UserId = 1 }, new Comment() { Id = 2, UserId = 2 } };
    }
}