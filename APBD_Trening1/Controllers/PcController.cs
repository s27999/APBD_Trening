using Microsoft.AspNetCore.Mvc;

namespace APBD_Trening1.Controllers;

//Dziedziczy po ControllerBase
[Route("api/[controller]")]
[ApiController]
public class PcController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok();
    }
}