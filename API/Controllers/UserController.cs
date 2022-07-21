using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{

    private DatabaseService databaseService;
    public UserController()
    {
        databaseService = new DatabaseService();
    }

    [HttpGet(Name = "GetAllUser")]
    public String Get()
    {
        return databaseService.getAllUser();
    }

    [HttpPost]
    public IActionResult Create(User user)
    {
        Console.WriteLine(user.Name ) ;
        return CreatedAtAction(nameof(Create), new { id = user.Name }, user);
    }
}