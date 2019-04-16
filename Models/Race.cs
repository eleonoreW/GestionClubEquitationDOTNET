using System;
using System.Collections.Generic;

namespace ClubEquitation.Models
{
    public partial class Race
    {
        public Race()
        {
            Cheval = new HashSet<Cheval>();
        }

        public int Id { get; set; }
        public string Nom { get; set; }

        public ICollection<Cheval> Cheval { get; set; }
    }
}
