using AuctionDemo.Infra.Data.Contexts;
using AuctionDemo.Infra.Data.Interfaces;
using AuctionDemo.Model.Entities;

namespace AuctionDemo.Infra.Data.Repositories;

public class OfferRepository(PostgresqlContext context) : IOfferRepository
{
    protected readonly PostgresqlContext _postgresqlContext = context;

    public void Create(Offer entity)
    {
        _postgresqlContext.Offers.Add(entity);
        _postgresqlContext.SaveChanges();
    }

    public List<Offer>? GetAll()
    {
        var offers = _postgresqlContext
            .Offers.ToList();

        return offers;
    }
}
