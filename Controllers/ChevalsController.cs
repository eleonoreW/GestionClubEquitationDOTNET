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
    public class ChevalsController : Controller
    {
        private readonly BDClubEquitationContext _context;
        private readonly ClubEquitationContext _Identitycontext;

        public ChevalsController(BDClubEquitationContext context, ClubEquitationContext Identitycontext)
        {
            _context = context;
            _Identitycontext = Identitycontext;
        }
        // GET: Chevals
        /*public async Task<IActionResult> Index()
        {
            var bDClubEquitationContext = _context.Cheval.Include(c => c.Proprietaire).Include(c => c.Race);
            return View(await bDClubEquitationContext.ToListAsync());
        }*/
        public async Task<IActionResult> Index(string searchString)
        {
            var chevaux = from c in _context.Cheval.Include(c => c.Proprietaire).Include(c => c.Race)
            select c;

            if (!String.IsNullOrEmpty(searchString))
            {
                chevaux = chevaux.Where(s => s.SearchString.Contains(searchString));
            }

            return View(await chevaux.ToListAsync());
        }
        public async Task<IActionResult> RechAv(int tailleMin, int tailleMax, string nom)
        {
            var chevaux = from c in _context.Cheval.Include(c => c.Proprietaire).Include(c => c.Race)
                          select c;

            if (!String.IsNullOrEmpty(nom))
            {
                chevaux = chevaux.Where(s => s.Nom.Contains(nom));
            }
            if (tailleMin > 0)
            {
                chevaux = chevaux.Where(s => s.Taille >= tailleMin);
            }
            if (tailleMax > 0)
            {
                chevaux = chevaux.Where(s => s.Taille <= tailleMax);
            }

            return View("Index", await chevaux.ToListAsync());
        }

        // GET: Chevals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cheval = await _context.Cheval
                .Include(c => c.Proprietaire)
                .Include(c => c.Race)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cheval == null)
            {
                return NotFound();
            }

            return View(cheval);
        }

        // GET: Chevals/Create
        public IActionResult Create()
        {
            ViewData["ProprietaireId"] = new SelectList(_Identitycontext.Users, "Id", "UserName");
            ViewData["RaceId"] = new SelectList(_context.Race, "Id", "Nom");
            return View();
        }

        // POST: Chevals/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProprietaireId,RaceId,Nom,DateNaissance,Descriptif,Commentaire,NbHeureMaxSemaine,Taille")] Cheval cheval)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cheval);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProprietaireId"] = new SelectList(_Identitycontext.Users, "Id", "UserName", cheval.ProprietaireId);
            ViewData["RaceId"] = new SelectList(_context.Race, "Id", "Nom", cheval.RaceId);
            return View(cheval);
        }

        // GET: Chevals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cheval = await _context.Cheval.FindAsync(id);
            if (cheval == null)
            {
                return NotFound();
            }
            ViewData["ProprietaireId"] = new SelectList(_Identitycontext.Users, "Id", "UserName", cheval.ProprietaireId);
            ViewData["RaceId"] = new SelectList(_context.Race, "Id", "Nom", cheval.RaceId);
            return View(cheval);
        }

        // POST: Chevals/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProprietaireId,RaceId,Nom,DateNaissance,Descriptif,Commentaire,NbHeureMaxSemaine,Taille")] Cheval cheval)
        {
            if (id != cheval.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cheval);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ChevalExists(cheval.Id))
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
            ViewData["ProprietaireId"] = new SelectList(_Identitycontext.Users, "Id", "UserName", cheval.ProprietaireId);
            ViewData["RaceId"] = new SelectList(_context.Race, "Id", "Nom", cheval.RaceId);
            return View(cheval);
        }

        // GET: Chevals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cheval = await _context.Cheval
                .Include(c => c.Proprietaire)
                .Include(c => c.Race)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cheval == null)
            {
                return NotFound();
            }

            return View(cheval);
        }

        // POST: Chevals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cheval = await _context.Cheval.FindAsync(id);
            _context.Cheval.Remove(cheval);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ChevalExists(int id)
        {
            return _context.Cheval.Any(e => e.Id == id);
        }
    }
}
