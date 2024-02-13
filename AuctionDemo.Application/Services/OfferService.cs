using AuctionDemo.Application.Interceptors;
using AuctionDemo.Infra.Data.Interfaces;
using AuctionDemo.Model.Commands;
using AuctionDemo.Model.Entities;

namespace AuctionDemo.Application.Services;

public class OfferService(LoggedUserInterceptor loggedUser, IOfferRepository repository)
{
    private readonly LoggedUserInterceptor _loggedUser = loggedUser;
    private readonly IOfferRepository _repository = repository;

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

    public List<Offer>? GetAll()
    {
        var offers = _repository.GetAll();

        return offers;
    }
}