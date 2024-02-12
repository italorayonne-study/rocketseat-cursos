using AuctionDemo.Application.Services;
using AuctionDemo.Model.Commands;
using AuctionDemo.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AuctionDemo.Application.Controllers;

[Route("[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpPost]
    public IActionResult Create([FromServices] UserService service, [FromBody] CreateUserCommandRequest request)
    {

        service.Create(request);

        return Created(string.Empty, "Resource Created!");

    }

}