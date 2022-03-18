using Microsoft.AspNetCore.Mvc;

namespace TeaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TeaController : ControllerBase
    {
        private static readonly string[] Teas = new[]
        {
           "Green", "Peppermint", "Earl Grey", "English Breakfast", "Camomile"
        };
        
        [HttpGet]
        public ActionResult GetAllCoffeeTypes()
        {
            var rnd = new Random();
            
            return Ok(Teas[rnd.Next(Teas.Length)]);
        }
    }

}