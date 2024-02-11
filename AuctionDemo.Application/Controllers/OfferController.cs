using AuctionDemo.Application.Services;
using AuctionDemo.Filters;
using AuctionDemo.Model.Commands;
using Microsoft.AspNetCore.Mvc;

namespace AuctionDemo.Application.Controllers;

[Route("[controller]")]
[ApiController]
[ServiceFilter(typeof(AuthenticationUserAttribute))]
public class OfferController() : ControllerBase
{

    [HttpPost("{itemId}")]
    public IActionResult CreateOffer([FromServices] OfferService service, [FromRoute] Guid itemId, [FromBody] CreateOfferCommandRequest request)
    {
        service.Create(itemId, request);

        return Created(string.Empty, "Resource created!");
    }
}