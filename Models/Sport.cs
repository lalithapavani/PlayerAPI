using System;
using System.Collections.Generic;

#nullable disable

namespace SportsEventAPI.Models
{
    public partial class Sport
    {
        public Sport()
        {
            Participations = new HashSet<Participation>();
        }

        public int SportsId { get; set; }
        public int? NoOfPlayers { get; set; }
        public string SportsName { get; set; }
        public string SportsType { get; set; }

        public virtual ICollection<Participation> Participations { get; set; }
    }
}
