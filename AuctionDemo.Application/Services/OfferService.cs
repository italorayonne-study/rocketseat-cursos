using AuctionDemo.Application.Interceptors;
using AuctionDemo.Infra.Data.Repositories;
using AuctionDemo.Model.Commands;
using AuctionDemo.Model.Entities;
using AuctionDemo.Model.Interfaces;

namespace AuctionDemo.Application.Services;

public class OfferService(LoggedUserInterceptor loggedUser) : IOffer
{
    private readonly LoggedUserInterceptor _loggedUser = loggedUser;
    private readonly OfferRepository _repository = new();

    public void Create(Guid itemId, CreateOfferCommandRequest request)
    {
        var user = _loggedUser.User();

        var offer = new Offer
        {
            CreatedAt = DateTime.Now,
            ItemId = itemId,
            Price = request.Price,
            UserId = user.Id
        };

        _repository.Create(offer);
    }
}