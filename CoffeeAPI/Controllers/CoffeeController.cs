using Microsoft.AspNetCore.Mvc;

namespace CoffeeAPI.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class CoffeeController : ControllerBase
{
    private static readonly List<string> Coffee = new()
    {
        "Coffee1", "Coffee2"
    };

    public IActionResult RandomCoffee()
    {
        return Ok(Coffee[Random.Shared.Next(Coffee.Count)]);
    }
}