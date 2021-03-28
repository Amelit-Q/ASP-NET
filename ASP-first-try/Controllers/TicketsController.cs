using Microsoft.AspNetCore.Mvc;

namespace ASP_first_try.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        [Route("/api/tickets")]
        public IActionResult Get()
        {
            return Ok("All the tickets was readed from database");
        }
        
        [HttpGet]
        [Route("api/tickets/{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"HEY YOU ARE USING TICKETS CONTROLLERS GET PARAM THAT'S IT TICKETS ID IS #{id}");
        }

        [HttpPost]
        [Route("api/tickets/")]
        public IActionResult Post()
        {
            return Ok("Creating a tickets");
        }

        [HttpPut]
        [Route("api/tickets")]
        public IActionResult Put()
        {
            return Ok("Updating a tickets");
        }

        [HttpDelete]
        [Route("api/tickets/{id}")]

        public IActionResult Delete(int id)
        {
            return Ok($"Deleting ticket #{id}");
        }
    }
}