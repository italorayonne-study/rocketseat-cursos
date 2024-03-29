using AuctionDemo.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionDemo.Infra.Data.Contexts;

public class PostgresqlContext(DbContextOptions<PostgresqlContext> options) : DbContext(options)
{
    public DbSet<Auction> Auctions { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<Offer> Offers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder
        .HasPostgresExtension("uuid-ossp");
}