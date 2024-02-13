using AuctionDemo.Model.Entities;

namespace AuctionDemo.Infra.Data.Interfaces;

public interface IOfferRepository
{
    void Create(Offer entity);
    List<Offer>? GetAll();
}