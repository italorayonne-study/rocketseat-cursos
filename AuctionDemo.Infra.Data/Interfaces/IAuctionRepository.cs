using AuctionDemo.Model.Entities;

namespace AuctionDemo.Infra.Data.Interfaces;

public interface IAuctionRepository
{
    void Create(Auction entity);
    List<Auction>? GetAuctions();
}