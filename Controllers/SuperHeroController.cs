using api.Entities;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class SuperHeroController : ControllerBase
  {
    [HttpGet]
    public async Task<ActionResult<List<SuperHero>>> GetAllHeroes()
    {
      var heroes = new List<SuperHero>() {
        new SuperHero {
          Id = 1,
          Name = "Spiderman",
          FirstName = "Peter",
          LastName = "Parker",
          Place = "New York City"
        }
      };
      return Ok(heroes);
    }
  }
}