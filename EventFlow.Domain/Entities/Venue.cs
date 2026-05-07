using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventFlow.Domain.Entities
{
    internal class Venue
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public int Capacity { get; set; }
        public ICollection<Event> Events { get; set; } = new List<Event>();
    }
}
