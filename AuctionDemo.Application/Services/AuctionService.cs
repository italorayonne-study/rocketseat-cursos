using AuctionDemo.Infra.Data.Repositories;
using AuctionDemo.Model.Entities;
using AuctionDemo.Model.Interfaces;

namespace AuctionDemo.Application.Services;

public class AuctionService : IAuction
{
    private readonly AuctionRepository _repository = new();

    public void Create()
    {
        Auction auction = new()
        {
            Id = Guid.NewGuid(),
            Name = "Rocketseat Expert",
            Starts = DateTime.Today,
            Ends = DateTime.Today.AddDays(5)
        };

        _repository.Create(auction);

    }

    public List<Auction>? GetAuctions()
    {
        var auctions = _repository.GetAuctions();

        return auctions;
    }

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