using AuctionDemo.Application.Services;
using AuctionDemo.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AuctionDemo.Application.Controllers;

[Route("[controller]")]
[ApiController]

public class AuctionController() : ControllerBase
{
    private readonly AuctionService? _service = new();


    [HttpGet]
    [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetCurrent()
    {

        var current = _service!.GetAuctions();

        return Ok(current);

    }
}