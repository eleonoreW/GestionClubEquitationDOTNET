using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClubEquitation.Models;
using Microsoft.AspNetCore.Identity;

namespace ClubEquitation.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the ClubEquitationUser class
    public class ClubEquitationUser : IdentityUser
    {
        public ClubEquitationUser()
        {
            Activite = new HashSet<Activite>();
            Cheval = new HashSet<Cheval>();
            Reservation = new HashSet<Reservation>();
        }

        public string Prenom { get; set; }
        public string Nom { get; set; }
        public ICollection<Activite> Activite { get; set; }
        public ICollection<Cheval> Cheval { get; set; }
        public ICollection<Reservation> Reservation { get; set; }

    }
}
