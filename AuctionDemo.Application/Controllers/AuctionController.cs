using AuctionDemo.Application.Services;
using AuctionDemo.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace AuctionDemo.Application.Controllers;

[Route("[controller]")]
[ApiController]

public class AuctionController() : ControllerBase
{

    [HttpGet]
    [ProducesResponseType(typeof(Auction), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetCurrent([FromServices] AuctionService service)
    {

        var current = service.GetAuctions();

        return Ok(current);
    }
}