using AuthAPI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace AuthAPI.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class AuthController : ControllerBase
{
    private readonly TokenService _tokenService;

    public AuthController(TokenService tokenService)
    {
        _tokenService = tokenService;
    }

    public IActionResult Login(string username)
    {
        var token = _tokenService.CreateAccessToken(username);

        return Ok(token);
    }

    [Authorize]
    public IActionResult IsAuthorized()
    {
        return Ok();
    }
}