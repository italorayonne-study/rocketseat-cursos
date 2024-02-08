using AuctionDemo.Application.Services;
using AuctionDemo.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AuctionDemo.Application.Controllers;

[Route("api/v1")]
[ApiController]

public class AuctionController() : ControllerBase
{
    private readonly AuctionService? _service = new();


    [HttpGet("auction")]
    [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetCurrent()
    {

        var current = _service!.GetAuctions();

        if (current?.Count == 0) return NoContent();

        return Ok(current);

    }
}