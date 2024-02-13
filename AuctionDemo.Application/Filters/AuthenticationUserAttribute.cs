using System.Text;
using AuctionDemo.Application.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace AuctionDemo.Filters;

public class AuthenticationUserAttribute(UserService service) : AuthorizeAttribute, IAuthorizationFilter
{
    private readonly UserService _service = service;
    public void OnAuthorization(AuthorizationFilterContext context)
    {
        try
        {
            var token = TokenOnRequest(context.HttpContext);
            var email = FromBase64String(token);

            bool exists = _service.ExistsByEmail(email);

            if (!exists) context.Result = new UnauthorizedObjectResult("Unauthorized");
        }
        catch (Exception ex)
        {
            context.Result = new UnauthorizedObjectResult(ex.Message);
        }
    }
    private static string TokenOnRequest(HttpContext context)
    {
        var authentication = context.Request.Headers.Authorization.ToString();

        if (string.IsNullOrEmpty(authentication)) throw new Exception("Token is missing!");

        return authentication["Bearer ".Length..];
    }
    private static string FromBase64String(string base64)
    {
        var data = Convert.FromBase64String(base64);

        return Encoding.UTF8.GetString(data);
    }
}