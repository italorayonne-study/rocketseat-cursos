using AuctionDemo.Model.Entities;

namespace AuctionDemo.Model.Interfaces;

public interface IAuction
{
    List<Auction> GetAuctions();
    Auction GetCurrent();
    void Create();

}