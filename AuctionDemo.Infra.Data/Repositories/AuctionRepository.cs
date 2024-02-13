using AuctionDemo.Infra.Data.Contexts;
using AuctionDemo.Infra.Data.Interfaces;
using AuctionDemo.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionDemo.Infra.Data.Repositories;

public class AuctionRepository(PostgresqlContext context) : IAuctionRepository
{
    protected readonly PostgresqlContext _postgresqlContext = context;
    public void Create(Auction entity)
    {
        _postgresqlContext.Auctions.Add(entity);
        _postgresqlContext.SaveChanges();
    }

    public List<Auction> GetAuctions()
    {
        var auctions = _postgresqlContext
        .Auctions
        .Include(auction => auction.Items)
        .ToList();

        return auctions;
    }
}