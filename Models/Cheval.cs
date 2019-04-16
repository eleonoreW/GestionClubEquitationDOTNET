using ClubEquitation.Areas.Identity.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ClubEquitation.Models
{
    public partial class Cheval
    {
        public Cheval()
        {
            ChevalActivite = new HashSet<ChevalActivite>();
        }

        public int Id { get; set; }
        public string ProprietaireId { get; set; }
        public int RaceId { get; set; }
        public string Nom { get; set; }
        [DataType(DataType.Date)]
        public DateTime DateNaissance { get; set; }
        public string Descriptif { get; set; }
        public string Commentaire { get; set; }
        [Range(0, 30)]
        public int NbHeureMaxSemaine { get; set; }
        [Range(0, 200)]
        public int Taille { get; set; }
        public string SearchString { get; set; }

        public virtual ClubEquitationUser Proprietaire { get; set; }
        public Race Race { get; set; }
        public ICollection<ChevalActivite> ChevalActivite { get; set; }
    }
}
