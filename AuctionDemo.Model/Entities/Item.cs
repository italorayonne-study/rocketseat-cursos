using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionDemo.Model.Entities;

[Table("Items")]
public class Item
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Brand { get; set; } = string.Empty;
    public int Condition { get; set; }
    public decimal BasePrice { get; set; }
    public Guid AuctionId { get; set; }
}