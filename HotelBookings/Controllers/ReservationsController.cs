using Microsoft.AspNetCore.Mvc;

namespace HotelBookings.Controllers;

[ApiController]
[Route("/reservations")]
public class ReservationsController : ControllerBase
{
    private readonly ILogger<ReservationsController> _logger;

    public ReservationsController(ILogger<ReservationsController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<ActionResult<>
    {
        return Enumerable.Range(1, 5).Select(index => new Reservation
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}

