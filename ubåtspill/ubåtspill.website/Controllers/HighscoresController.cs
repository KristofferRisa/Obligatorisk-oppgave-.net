using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ubåtspill.website.Models;

namespace ubåtspill.website.Controllers
{
    public class HighscoresController : Controller
    {
        private readonly HighscoreContext _context;

        public HighscoresController(HighscoreContext context)
        {
            _context = context;    
        }

        // GET: Highscores
        public async Task<IActionResult> Index()
        {
            return View(await _context.Highscores.OrderByDescending(x => x.Score).ToListAsync());
        }

        // GET: Highscores/Details/5
        [Authorize]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var highscore = await _context.Highscores
                .SingleOrDefaultAsync(m => m.HighscoreId == id);
            if (highscore == null)
            {
                return NotFound();
            }

            return View(highscore);
        }

        // GET: Highscores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Highscores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Name,Score,Level,Date")] Highscore highscore)
        {
            if (ModelState.IsValid && Request.Headers["Token"] == "12414141414")
            {
                _context.Add(highscore);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(highscore);
        }

        // GET: Highscores/Edit/5
        [Authorize]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var highscore = await _context.Highscores.SingleOrDefaultAsync(m => m.HighscoreId == id);
            if (highscore == null)
            {
                return NotFound();
            }
            return View(highscore);
        }

        // POST: Highscores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("HighscoreId,Name,Score,Level,Date")] Highscore highscore)
        {
            if (id != highscore.HighscoreId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(highscore);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HighscoreExists(highscore.HighscoreId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(highscore);
        }

        // GET: Highscores/Delete/5
        [Authorize]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var highscore = await _context.Highscores
                .SingleOrDefaultAsync(m => m.HighscoreId == id);
            if (highscore == null)
            {
                return NotFound();
            }

            return View(highscore);
        }

        // POST: Highscores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var highscore = await _context.Highscores.SingleOrDefaultAsync(m => m.HighscoreId == id);
            _context.Highscores.Remove(highscore);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool HighscoreExists(int id)
        {
            return _context.Highscores.Any(e => e.HighscoreId == id);
        }
    }
}
