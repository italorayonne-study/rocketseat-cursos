namespace AuctionDemo.Model.Commands;

public class CreateUserCommandRequest
{
    public string Name { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
}