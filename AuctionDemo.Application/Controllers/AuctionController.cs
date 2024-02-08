using AuctionDemo.Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace AuctionDemo.Application.Controllers;

[Route("api/v1/[controller]")]
[ApiController]

public class AuctionController() : ControllerBase
{
    private readonly AuctionService? _service = new();


    [HttpGet()]
    public IActionResult GetCurrent()
    {

        var current = _service!.GetAuctions();

        return Ok(current);

    }

    [HttpPost("create")]
    public IActionResult Create()
    {
        _service!.Create();

        return Created();
    }
}