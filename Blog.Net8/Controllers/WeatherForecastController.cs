using Blog.Net8.Model;
using Blog.Net8.Service;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Blog.Net8.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public async Task<List<UserVo>> Get()
    {
        var userService = new UserService();
        var userList = await userService.GetUsers();
        return userList;
    }
}
