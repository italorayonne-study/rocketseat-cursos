using AuctionDemo.Infra.Data.Contexts;
using AuctionDemo.Model.Entities;

namespace AuctionDemo.Infra.Data.Repositories;

public class UserRepository
{
    private readonly PostgresqlContext _context = new();

    public bool ExistsByEmail(string email)
    {
        return _context.Users.Any(source => source.Email.Equals(email));
    }

    public User GetByEmail(string email)
    {
        var user = _context.Users.First(user => user.Email.Equals(email));

        return user;
    }
}