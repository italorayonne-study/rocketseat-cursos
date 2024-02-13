using AuctionDemo.Infra.Data.Interfaces;
using AuctionDemo.Model.Entities;
using AuctionDemo.Model.Interfaces;

namespace AuctionDemo.Application.Services;

public class AuctionService(IAuctionRepository repository)
{
    private readonly IAuctionRepository? _repository = repository;

    public List<Auction>? GetAuctions()
    {
        var auctions = _repository!.GetAuctions();

        return auctions;
    }
}