using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace ASP_first_try.Models
{
    public class Ticket
    {
        public int TicketId { get; set; }
        [Required]
        [FromBody]
        public int ProjectId { get; set; }
        [Required]
        [FromBody]
        public string Title { get; set; }
        [FromBody]
        public string Description { get; set; }
    }
} 