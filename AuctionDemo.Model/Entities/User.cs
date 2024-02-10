using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionDemo.Model.Entities;

[Table("Users")]
public class User
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;

}