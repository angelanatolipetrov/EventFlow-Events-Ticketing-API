using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventFlow.Domain.Entities
{
    public class PurchasedTicket
    {
        public int Id { get; set; }
        public string UniqueCode { get; set; } = Guid.NewGuid().ToString();
        public DateTime IssueDate { get; set; }
        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; } = null!;
        public int TicketTypeId { get; set; }
        public TicketType TicketType { get; set; } = null!;
    }
}
