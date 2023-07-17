using Microsoft.AspNetCore.Mvc;

namespace DotnetJetpack.API.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<object> Get()
    {
        return new List<object>();
    }
}
