using API.Models;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class OAuthController : ControllerBase
{

    public OAuthController() { }

    [HttpGet("/auth/registerCode")]
    public void GoogleAuth(HttpRequestMessage request)
    {
        IEnumerable<string> headerValues = request.Headers.GetValues("code");
        var id = headerValues.FirstOrDefault();
        Console.WriteLine("hi");
        Console.WriteLine(id);
        foreach (var header in Request.Headers)
        {
            Console.Write("Key: ");
            Console.WriteLine(header.Key);
            Console.Write("Value: ");
            Console.WriteLine(header.Value);
        }
        var pizza = PizzaService.Get(0);
    }

}