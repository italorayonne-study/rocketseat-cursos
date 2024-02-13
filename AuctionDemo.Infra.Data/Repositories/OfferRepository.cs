using AuctionDemo.Infra.Data.Contexts;
using AuctionDemo.Model.Entities;

namespace AuctionDemo.Infra.Data.Repositories;

public class OfferRepository
{
    protected readonly PostgresqlContext _postgresqlContext;

    public void Create(Offer entity)
    {
        _postgresqlContext.Offers.Add(entity);
        _postgresqlContext.SaveChanges();
    }

    public List<Offer> GetAll()
    {
        var offers = _postgresqlContext.Offers.ToList();

        return offers;
    }
}
