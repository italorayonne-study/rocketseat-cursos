using AuctionDemo.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace AuctionDemo.Application.Controllers;

[Route("api/v1/[controller]")]
[ApiController]

public class AuctionController() : ControllerBase
{
    private readonly AuctionService? _service = new();


    [HttpGet("current")]
    public IActionResult GetCurrent()
    {

        var current = _service!.GetCurrent();

        return Ok(current);

    }
}