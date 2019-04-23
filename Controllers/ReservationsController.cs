using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClubEquitation.Models;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using ClubEquitation.Areas.Identity.Data;

namespace ClubEquitation.Controllers
{
    [Authorize]
    public class ReservationsController : Controller
    {
        private readonly BDClubEquitationContext _context;
        private readonly ClubEquitationContext _Identitycontext;
        public ReservationsController(BDClubEquitationContext context, ClubEquitationContext Identitycontext)
        {
            _context = context;
            _Identitycontext = Identitycontext;
        }

        // GET: Reservations
        public async Task<IActionResult> Index()
        {
            var currentUser = this.User.FindFirstValue(ClaimTypes.NameIdentifier).ToString();
            var bDClubEquitationContext = _context.Reservation.Include(r => r.Activite).Include(r => r.Utilisateur).Where(s => s.UtilisateurId.Equals(currentUser));
            return View(await bDClubEquitationContext.ToListAsync());
        }

        // GET: Reservations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation
                .Include(r => r.Activite)
                .Include(r => r.Utilisateur)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // GET: Reservations/Create
        public async Task<IActionResult> Create(String idActivite, int nbPlaces)
        {
            ViewBag.ActiviteId = idActivite;
            ViewBag.NbPlaces = nbPlaces;

            return View();
        }

        // POST: Reservations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NbPersonne,ActiviteId")] Reservation reservation)
        {
            if (ModelState.IsValid)
            {
                reservation.UtilisateurId = this.User.FindFirstValue(ClaimTypes.NameIdentifier).ToString();
                reservation.Utilisateur = _context.Find<ClubEquitationUser>(this.User.FindFirstValue(ClaimTypes.NameIdentifier).ToString());
                _context.Add(reservation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(reservation);
        }

        // GET: Reservations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation.FindAsync(id);
            if (reservation == null)
            {
                return NotFound();
            }
            ViewData["ActiviteId"] = new SelectList(_context.Activite, "Id", "Nom", reservation.ActiviteId);
            ViewData["UtilisateurId"] = new SelectList(_Identitycontext.Users, "Id", "UserName", reservation.UtilisateurId);
            
            return View(reservation);
        }

        // POST: Reservations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,NbPersonne,EstActive,UtilisateurId,ActiviteId")] Reservation reservation)
        {
            if (id != reservation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reservation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReservationExists(reservation.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["ActiviteId"] = new SelectList(_context.Activite, "Id", "Nom", reservation.ActiviteId);
            ViewData["UtilisateurId"] = new SelectList(_Identitycontext.Users, "Id", "UserName", reservation.UtilisateurId);
            return View(reservation);
        }

        // GET: Reservations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reservation = await _context.Reservation
                .Include(r => r.Activite)
                .Include(r => r.Utilisateur)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (reservation == null)
            {
                return NotFound();
            }

            return View(reservation);
        }

        // POST: Reservations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reservation = await _context.Reservation.FindAsync(id);
            _context.Reservation.Remove(reservation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReservationExists(int id)
        {
            return _context.Reservation.Any(e => e.Id == id);
        }

        public int NbPlacesRestantes(Activite activite)
        {
            int NbPlacesRestantes = activite.Capacite;
            var reservations = from c in _context.Reservation select c;
            reservations = reservations.Where(s => s.ActiviteId.Equals(activite.Id));
            reservations = reservations.Where(s => s.EstActive.Equals(true));
            foreach (Reservation res in reservations)
            {
                NbPlacesRestantes -= res.NbPersonne;
            }
            return NbPlacesRestantes;
        }


    }
}
