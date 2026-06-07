using APBD_Trening1.Data;
using APBD_Trening1.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace APBD_Trening1.Controllers;

//Dziedziczy po ControllerBase
[Route("api/pcs")]
[ApiController]
public class PcController : ControllerBase
{
    
    //Ustawiamy kontekst bazy danych
    private readonly AppDbContext _dbService;

    public PcController(AppDbContext dbContext)
    {
        _dbService = dbContext;
    }
    
    
    //Get na wszystkie listy, wykonywany asynchronicznie - wszystko musi być async lub mieć await
    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var res = await _dbService.PCs.ToListAsync();
        return Ok(res);
    }
}