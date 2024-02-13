using AuctionDemo.Infra.Data.Interfaces;
using AuctionDemo.Infra.Data.Repositories;
using AuctionDemo.Model.Commands;
using AuctionDemo.Model.Entities;

namespace AuctionDemo.Application.Services;

public class UserService(IUserRepository repository)
{

    private readonly IUserRepository _repository = repository;

    public void Create(CreateUserCommandRequest request)
    {
        var user = new User
        {
            Email = request.Email,
            Name = request.Name
        };

        _repository.Create(user);
    }

    public bool ExistsByEmail(string email)
    {
        return _repository.ExistsByEmail(email);
    }

    public User? GetByEmail(string email)
    {
        var user = _repository.GetByEmail(email);

        return user;
    }
}