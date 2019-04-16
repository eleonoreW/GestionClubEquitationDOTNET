using System;
using System.Collections.Generic;

namespace ClubEquitation.Models
{
    public partial class ChevalActivite
    {
        public int Id { get; set; }
        public int ChevalId { get; set; }
        public int ActiviteId { get; set; }

        public Activite Activite { get; set; }
        public Cheval Cheval { get; set; }
    }
}
