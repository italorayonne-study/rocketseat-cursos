using AuctionDemo.Infra.Data.Contexts;
using AuctionDemo.Model.Entities;

namespace AuctionDemo.Infra.Data.Repositories;

public class AuctionRepository
{
    protected readonly PostgresqlContext _postgresqlContext = new();
    public void Create(Auction entity)
    {
        _postgresqlContext.Auctions.Add(entity);
        _postgresqlContext.SaveChanges();
    }

    public List<Auction> GetAuctions()
    {
        var auctions = _postgresqlContext.Auctions.ToList();

        return auctions;
    }
}