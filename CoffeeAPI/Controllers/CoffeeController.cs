using Microsoft.AspNetCore.Mvc;

namespace CoffeeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CoffeeController : ControllerBase
    {
        private static readonly string[] Coffees = new[]
        {
            "Flat White", "Long Black", "Latte", "Americano", "Cappuccino"
        };
        
        [HttpGet]
        public ActionResult GetAllCoffeeTypes()
        {
            var rnd = new Random();
            
            return Ok(Coffees[rnd.Next(Coffees.Length)]);
        }
    }

}