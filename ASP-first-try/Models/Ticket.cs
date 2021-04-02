using System;
using System.ComponentModel.DataAnnotations;
using ASP_first_try.ModelValidations;
using Microsoft.AspNetCore.Mvc;

namespace ASP_first_try.Models
{
    public class Ticket
    {
        [FromBody] public int? TicketId { get; set; }
        [Required] [FromBody] public int? ProjectId { get; set; }
        [Required] [FromBody] public string Title { get; set; }
        [FromBody] public string Description { get; set; }
        public string Owner { get; set; }

        [Ticket_EnsureDueDateTicketOwner] public DateTime? DueDate { get; set; }
    }
}