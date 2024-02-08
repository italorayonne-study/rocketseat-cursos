using AuctionDemo.Model.Entities;
using Microsoft.EntityFrameworkCore;

namespace AuctionDemo.Infra.Data.Contexts;

public class PostgresqlContext : DbContext
{
    public DbSet<Auction> Auctions { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder
        .UseNpgsql("Host=localhost;Database=auction_demo;Username=maidensix;Password=M41d3nsix00");
    protected override void OnModelCreating(ModelBuilder modelBuilder) => modelBuilder
        .HasPostgresExtension("uuid-ossp");
}