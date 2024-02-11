using AuctionDemo.Model.Entities;

namespace AuctionDemo.Model.Interfaces;

public interface IUser
{
    bool ExistsByEmail(string email);
    User GetByEmail(string email);
}