using AuctionDemo.Model.Entities;

namespace AuctionDemo.Infra.Data.Interfaces;

public interface IUserRepository
{
    bool ExistsByEmail(string email);
    User? GetByEmail(string email);
    void Create(User entity);
}