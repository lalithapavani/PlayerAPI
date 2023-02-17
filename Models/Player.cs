using System;
using System.Collections.Generic;

#nullable disable

namespace SportsEventAPI.Models
{
    public partial class Player
    {
        public Player()
        {
            Participations = new HashSet<Participation>();
        }

        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int Age { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public string SportsName { get; set; }

        public virtual ICollection<Participation> Participations { get; set; }
    }
}
