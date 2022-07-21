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

    /*     [HttpPost(Name = "CreateUser")]
        public String Post()
        {
            //Console.WriteLine(rawRequestBody);
            return "Ok()";
        } */
    [HttpPost("cancelRequestAccess")]
    public String test([FromBody] string name)
    {
        return "model";
    }
}