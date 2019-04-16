using ClubEquitation.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClubEquitation.Models
{
    public partial class Reservation
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        [Range(0, 200)]
        public int NbPersonne { get; set; }
        public bool EstActive { get; set; }
        public string UtilisateurId { get; set; }
        public int ActiviteId { get; set; }
        public string SearchString { get; set; }

        public Activite Activite { get; set; }
        public virtual ClubEquitationUser Utilisateur { get; set; }

        public Reservation()
        {
            Date = DateTime.Now;
            EstActive = true;
        }
    }
}
