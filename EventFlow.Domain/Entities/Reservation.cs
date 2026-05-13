using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventFlow.Domain.Entities
{
    public class Reservation
    {
        public int Id { get; set; }
        public DateTime ReservationDate { get; set; }
        public string Status { get; set; } = "Pending"; 
        public decimal TotalPrice { get; set; }
        public int UserId { get; set; }
        public User User { get; set; } = null!;
        public ICollection<ReservationItem> Items { get; set; } = new List<ReservationItem>();
    }
}

