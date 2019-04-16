using ClubEquitation.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClubEquitation.Models
{
    public partial class Activite
    {
        public Activite()
        {
            ChevalActivite = new HashSet<ChevalActivite>();
            Reservation = new HashSet<Reservation>();
            EstActive = true;
        }

        public int Id { get; set; }
        public string ProfesseurId { get; set; }
        public int LieuId { get; set; }
        public int TypeId { get; set; }
        public string Nom { get; set; }
        public string Commentaire { get; set; }
        public string Details { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Range(0, 200)]
        public int Duree { get; set; }
        [Range(0, 30)]
        public int Capacite { get; set; }
        public bool EstActive { get; set; }
        public string SearchString { get; set; }

        public Lieu Lieu { get; set; }
        public virtual ClubEquitationUser Professeur { get; set; }
        public Type Type { get; set; }
        public ICollection<ChevalActivite> ChevalActivite { get; set; }
        public ICollection<Reservation> Reservation { get; set; }
    }
}
