using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionDemo.Model.Entities;

[Table("Offers")]
public class Offer
{
    public Guid Id { get; set; }
    public DateTime CreatedAt { get; set; }
    public decimal Price { get; set; }
    public Guid UserId { get; set; }
    public Guid ItemId { get; set; }
}