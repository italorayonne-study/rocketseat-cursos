using System.Text;
using AuctionDemo.Application.Services;
using AuctionDemo.Model.Entities;

namespace AuctionDemo.Application.Interceptors;

public class LoggedUserInterceptor(IHttpContextAccessor context)
{
    private readonly IHttpContextAccessor _context = context;
    private readonly UserService _service = new();

    public User User()
    {
        var token = TokenOnRequest();
        var email = FromBase64String(token);

        return _service.GetByEmail(email);

    }

    private string TokenOnRequest()
    {
        var authentication = _context.HttpContext!.Request.Headers.Authorization.ToString();

        return authentication["Bearer ".Length..];
    }
    private static string FromBase64String(string base64)
    {
        var data = Convert.FromBase64String(base64);

        return Encoding.UTF8.GetString(data);
    }
}