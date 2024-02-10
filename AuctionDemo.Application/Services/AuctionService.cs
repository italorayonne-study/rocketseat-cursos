using AuctionDemo.Infra.Data.Repositories;
using AuctionDemo.Model.Entities;
using AuctionDemo.Model.Interfaces;

namespace AuctionDemo.Application.Services;

public class AuctionService : IAuction
{
    private readonly AuctionRepository _repository = new();

    public List<Auction> GetAuctions()
    {
        var auctions = _repository.GetAuctions();

        return auctions;
    }
}