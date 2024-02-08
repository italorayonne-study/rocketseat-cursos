using AuctionDemo.Infra.Data.Contexts;
using AuctionDemo.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionDemo.Infra.Data.Repositories;

public class AuctionRepository
{
    protected readonly PostgresqlContext _postgresqlContext = new();
    public void Create(Auction entity)
    {
        _postgresqlContext.Auctions.Add(entity);
        _postgresqlContext.SaveChanges();
    }

    public List<Auction>? GetAuctions()
    {
        var auctions = _postgresqlContext.Auctions
            .Include(auctions => auctions.Items)
            .Where(auction => DateTime.Now >= auction.Starts && DateTime.Now <= auction.Ends)
            .ToList();

        return auctions;
    }
}