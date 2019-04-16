using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClubEquitation.Models
{
    public partial class Lieu
    {
        public Lieu()
        {
            Activite = new HashSet<Activite>();
        }

        public int Id { get; set; }
        public string Nom { get; set; }
        [Range(0, 200)]
        public int Capacite { get; set; }
        public string Descriptif { get; set; }

        public ICollection<Activite> Activite { get; set; }
    }
}
