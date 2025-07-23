using Microsoft.AspNetCore.Mvc;
namespace VehicleService.Controllers;

[ApiController]
[Route("[controller]")]
public class VehicleController : ControllerBase
{
    [HttpGet("{id}")]
    public IActionResult GetVehicle(string id)
    {
        var vehicle = new
        {
            Id = id,
            Make = "Toyota",
            Model = "Corolla",
            Year = 2022
        };
        return Ok(vehicle);
    }
}
