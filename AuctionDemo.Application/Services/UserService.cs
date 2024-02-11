using AuctionDemo.Infra.Data.Repositories;
using AuctionDemo.Model.Entities;
using AuctionDemo.Model.Interfaces;

namespace AuctionDemo.Application.Services;

public class UserService : IUser
{

    private readonly UserRepository _repository = new();

    public bool ExistsByEmail(string email)
    {
        return _repository.ExistsByEmail(email);
    }

    public User GetByEmail(string email)
    {
        var user = _repository.GetByEmail(email);

        return user;
    }
}