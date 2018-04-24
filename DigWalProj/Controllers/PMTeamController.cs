using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DigWalProj.Data;
using DigWalProj.Models;

namespace DigWalProj.Controllers
{
    public class PMTeamController : Controller
    {
        private readonly DatabaseContext _context;

        public PMTeamController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: PMTeam
        public async Task<IActionResult> Index()
        {
            return View(await _context.PMTeam.ToListAsync());
        }

        // GET: PMTeam/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pMTeam = await _context.PMTeam
                .SingleOrDefaultAsync(m => m.teamId == id);
            if (pMTeam == null)
            {
                return NotFound();
            }

            return View(pMTeam);
        }

        // GET: PMTeam/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PMTeam/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("teamId,teamName,teamDescription")] PMTeam pMTeam)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pMTeam);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pMTeam);
        }

        // GET: PMTeam/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pMTeam = await _context.PMTeam.SingleOrDefaultAsync(m => m.teamId == id);
            if (pMTeam == null)
            {
                return NotFound();
            }
            return View(pMTeam);
        }

        // POST: PMTeam/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("teamId,teamName,teamDescription")] PMTeam pMTeam)
        {
            if (id != pMTeam.teamId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pMTeam);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PMTeamExists(pMTeam.teamId))
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
            return View(pMTeam);
        }

        // GET: PMTeam/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pMTeam = await _context.PMTeam
                .SingleOrDefaultAsync(m => m.teamId == id);
            if (pMTeam == null)
            {
                return NotFound();
            }

            return View(pMTeam);
        }

        // POST: PMTeam/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pMTeam = await _context.PMTeam.SingleOrDefaultAsync(m => m.teamId == id);
            _context.PMTeam.Remove(pMTeam);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PMTeamExists(int id)
        {
            return _context.PMTeam.Any(e => e.teamId == id);
        }
    }
}
