using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventFlow.Domain.Entities
{
    public class ReservationItem
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerUnit { get; set; }
        public int ReservationId { get; set; }
        public Reservation Reservation { get; set; } = null!;
        public int TicketTypeId { get; set; }
        public TicketType TicketType { get; set; } = null!;
    }
}
