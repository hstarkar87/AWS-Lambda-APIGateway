using Microsoft.AspNetCore.Mvc;
namespace VehicleService.Controllers;

[ApiController]
[Route("price")]
public class PriceController : ControllerBase
{
    [HttpGet("{vehicleId}")]
    public IActionResult GetPrice(string vehicleId)
    {
        var price = new
        {
            VehicleId = vehicleId,
            Currency = "USD",
            Amount = 20000
        };
        return Ok(price);
    }
}