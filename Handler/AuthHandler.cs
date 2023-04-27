using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text.Encodings.Web;
using WebApplication1.Services;

namespace WebApplication1.Handler;

public class AuthHandler : AuthenticationHandler<AuthenticationSchemeOptions>
{
    public AuthHandler(
        IOptionsMonitor<AuthenticationSchemeOptions> options,
        ILoggerFactory logger, 
        UrlEncoder encoder,
        ISystemClock clock) : base(options, logger, encoder, clock)
    {
    }

    protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        var claims = new List<Claim>()
        {
            new Claim("username", "ali")
        };
        var user = new ClaimsPrincipal(new ClaimsIdentity(claims));
        var ticket = new AuthenticationTicket(user, Scheme.Name);
        return await Task.FromResult(AuthenticateResult.Success(ticket));
    }
}
