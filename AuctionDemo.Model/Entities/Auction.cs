namespace AuctionDemo.Model.Entities;

public class Auction
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime Starts { get; set; }
    public DateTime Ends { get; set; }
}