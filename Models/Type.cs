using System;
using System.Collections.Generic;

namespace ClubEquitation.Models
{
    public partial class Type
    {
        public Type()
        {
            Activite = new HashSet<Activite>();
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        public string Descriptif { get; set; }

        public ICollection<Activite> Activite { get; set; }
    }
}
