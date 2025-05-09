using Microsoft.AspNetCore.Mvc;
using TavernSystem.Services;

namespace TavernSystem.Controllers;

[Route("/api/adventurers")]
[ApiController]


public class AdventurersController : ControllerBase
{
    
    private readonly IAdventurersService _service;



    [HttpGet]
    public ActionResult GetAllAdventurers()
    {
        return Ok("Successfully Retrieved All Adventurers");
    }

    [HttpGet("/{id}")]
    public IActionResult GetSingleAdventurer([FromQuery] int id)
    {
        return Ok("Successfully Retrieved Single Adventurer");
    }

    [HttpPost]
    public IActionResult AddNewAdventurer([FromBody] string request)
    {
        return Ok("Successfully Added New Adventurer");
    }
}