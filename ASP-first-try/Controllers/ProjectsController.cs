using ASP_first_try.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASP_first_try.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Reading all the projects");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"Reading the specific project Id which is equals to #{id}");
        }

        /// <summary>
        /// api/projects/{pid}
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/projects/{pid}/tickets")]
        public IActionResult GetProjectId(int pId, [FromQuery] int tId)
        {
            if (tId == 0)
            {
                return Ok($"Reading all the tickets belong to project #{pId}");
            }
            else
                return Ok($"Reading project #{pId}, tickets #{tId}");
        }

        // [HttpGet]
        // [Route("/api/projects/{pid}/tickets")]
        // public IActionResult GetProjectId([FromQuery] Ticket ticket)
        // {
        //     if (ticket == null) return BadRequest("Parameters are not provided properly!");
        //
        //     if (ticket.TicketId == 0)
        //     {
        //         return Ok($"Reading all the tickets belong to project #{ticket.ProjectId}");
        //     }
        //     else
        //         return Ok(
        //             $"Reading project #{ticket.ProjectId}, tickets #{ticket.TicketId}, title #{ticket.Title}, description #{ticket.Description}");
        // }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Creating a project");
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok("Updating a project");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Deleting ticket #{id}");
        }
    }
}