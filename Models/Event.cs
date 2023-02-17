using System;
using System.Collections.Generic;

#nullable disable

namespace SportsEventAPI.Models
{
    public partial class Event
    {
        public Event()
        {
            Participations = new HashSet<Participation>();
        }

        public int EventId { get; set; }
        public DateTime? EventDate { get; set; }
        public string EventName { get; set; }
        public int? NoofSlots { get; set; }
        public string SportsName { get; set; }

        public virtual ICollection<Participation> Participations { get; set; }
    }
}
