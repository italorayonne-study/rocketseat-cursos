using AuctionDemo.Model.Commands;
using AuctionDemo.Model.Entities;

namespace AuctionDemo.Model.Interfaces;

public interface IOffer
{
    void Create(Guid id, CreateOfferCommandRequest request);

    List<Offer> GetAll();
}