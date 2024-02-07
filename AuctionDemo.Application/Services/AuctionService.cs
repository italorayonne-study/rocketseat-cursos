using AuctionDemo.Model.Entities;
using AuctionDemo.Model.Interfaces;

namespace AuctionDemo.Application.Services;

public class AuctionService : IAuction
{
    public Auction GetCurrent()
    {
        Auction auction = new()
        {
            Id = Guid.NewGuid(),
            Name = "Rocketseat Expert",
            Starts = DateTime.Today,
            Ends = DateTime.Today.AddDays(5)
        };

        return auction;
    }
}