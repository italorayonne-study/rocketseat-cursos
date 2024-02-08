using AuctionDemo.Model.Entities;

namespace AuctionDemo.Model.Interfaces;

public interface IAuction
{
    Auction GetCurrent();
    void Create();

}