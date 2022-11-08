using Microsoft.AspNetCore.Mvc;

namespace HotelBookings.Controllers;

[ApiController]
[Route("/rooms")]
public class RoomsController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<RoomsController> _logger;

    public RoomsController(ILogger<RoomsController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<Room> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new Room
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}

