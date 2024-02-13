using AuctionDemo.Infra.Data.Contexts;
using AuctionDemo.Infra.Data.Interfaces;
using AuctionDemo.Model.Commands;
using AuctionDemo.Model.Entities;

namespace AuctionDemo.Infra.Data.Repositories;

public class UserRepository(PostgresqlContext context) : IUserRepository
{
    private readonly PostgresqlContext _postgresqlContext = context;

    public bool ExistsByEmail(string email)
    {
        return _postgresqlContext.Users
            .Any(source => source.Email
                .Equals(email));
    }

    public User? GetByEmail(string email)
    {
        var user = _postgresqlContext.Users
            .First(user => user.Email
                .Equals(email));

        return user;
    }

    public void Create(User entity)
    {
        _postgresqlContext.Users.Add(entity);
        _postgresqlContext.SaveChanges();
    }
}