using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventFlow.Domain.Entities
{
    public class Event
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime StartDate { get; set; }
        public string Status { get; set; } = "Draft"; 
        public int VenueId { get; set; }
        public Venue Venue { get; set; } = null!;
        public ICollection<TicketType> TicketTypes { get; set; } = new List<TicketType>();
    }
}
