using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ClubEquitation.Models;

namespace ClubEquitation.Controllers
{
    public class ActivitesController : Controller
    {
        private readonly BDClubEquitationContext _context;
        private readonly ClubEquitationContext _Identitycontext;

        public ActivitesController(BDClubEquitationContext context,ClubEquitationContext Identitycontext)
        {
            _context = context;
            _Identitycontext = Identitycontext;
        }

        // GET: Activites
        //public async Task<IActionResult> Index()
        //{
        //    var bDClubEquitationContext = _context.Activite.Include(a => a.Lieu).Include(a => a.Professeur).Include(a => a.Type);
        //    return View(await bDClubEquitationContext.ToListAsync());
        //}
        public async Task<IActionResult> Index(string searchString)
        {
            var activites = from a in _context.Activite.Include(a => a.Lieu).Include(a => a.Professeur).Include(a => a.Type)
            select a;

            if (!String.IsNullOrEmpty(searchString))
            {
                activites = activites.Where(s => s.SearchString.Contains(searchString));
            }

            return View(await activites.ToListAsync());
        }
        // GET: Activites/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activite = await _context.Activite
                .Include(a => a.Lieu)
                .Include(a => a.Professeur)
                .Include(a => a.Type)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (activite == null)
            {
                return NotFound();
            }

            return View(activite);
        }

        // GET: Activites/Create
        public IActionResult Create()
        {
            ViewData["LieuId"] = new SelectList(_context.Lieu, "Id", "Nom");
            ViewData["ProfesseurId"] = new SelectList(_Identitycontext.Users, "Id", "UserName");
            ViewData["TypeId"] = new SelectList(_context.Type, "Id", "Nom");
            return View();
        }

        // POST: Activites/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProfesseurId,LieuId,TypeId,Nom,Commentaire,Details,Date,Duree,Capacite")] Activite activite)
        {
            if (ModelState.IsValid)
            {
                _context.Add(activite);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["LieuId"] = new SelectList(_context.Lieu, "Id", "Nom", activite.LieuId);
            ViewData["ProfesseurId"] = new SelectList(_Identitycontext.Users, "Id", "UserName", activite.ProfesseurId);
            ViewData["TypeId"] = new SelectList(_context.Type, "Id", "Nom", activite.TypeId);
            return View(activite);
        }

        // GET: Activites/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activite = await _context.Activite.FindAsync(id);
            if (activite == null)
            {
                return NotFound();
            }
            ViewData["LieuId"] = new SelectList(_context.Lieu, "Id", "Nom", activite.LieuId);
            ViewData["ProfesseurId"] = new SelectList(_Identitycontext.Users, "Id", "UserName", activite.ProfesseurId);
            ViewData["TypeId"] = new SelectList(_context.Type, "Id", "Nom", activite.TypeId);
            return View(activite);
        }

        // POST: Activites/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProfesseurId,LieuId,TypeId,Nom,Commentaire,Details,Date,Duree,Capacite,EstActive")] Activite activite)
        {
            if (id != activite.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(activite);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ActiviteExists(activite.Id))
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
            ViewData["LieuId"] = new SelectList(_context.Lieu, "Id", "Nom", activite.LieuId);
            ViewData["ProfesseurId"] = new SelectList(_Identitycontext.Users, "Id", "UserName", activite.ProfesseurId);
            ViewData["TypeId"] = new SelectList(_context.Type, "Id", "Nom", activite.TypeId);
            return View(activite);
        }

        // GET: Activites/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activite = await _context.Activite
                .Include(a => a.Lieu)
                .Include(a => a.Professeur)
                .Include(a => a.Type)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (activite == null)
            {
                return NotFound();
            }

            return View(activite);
        }

        // POST: Activites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var activite = await _context.Activite.FindAsync(id);
            _context.Activite.Remove(activite);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ActiviteExists(int id)
        {
            return _context.Activite.Any(e => e.Id == id);
        }

        public async Task<IActionResult> Reserver(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var activite = await _context.Activite.FindAsync(id);
            if (activite == null)
            {
                return NotFound();
            }
            return RedirectToAction("Create", "Reservations", new { idActivite = activite.Id});
        }


    }
}
