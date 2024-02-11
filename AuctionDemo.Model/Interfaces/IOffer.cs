using AuctionDemo.Model.Commands;

namespace AuctionDemo.Model.Interfaces;

public interface IOffer
{
    void Create(Guid id, CreateOfferCommandRequest request);
}