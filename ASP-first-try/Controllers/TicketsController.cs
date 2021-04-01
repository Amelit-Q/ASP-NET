using ASP_first_try.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_first_try.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("All the tickets was readed from database");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"HEY YOU ARE USING TICKETS CONTROLLERS GET PARAM THAT'S IT TICKETS ID IS #{id}");
        }
        
        [HttpPost]
        public IActionResult Post([FromBody]Ticket ticket)
        {
            return Ok(ticket);
        }

        [HttpPut]
        public IActionResult Put([FromBody]Ticket ticket)
        {
            return Ok(ticket);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Deleting ticket #{id}");
        }
    }
}