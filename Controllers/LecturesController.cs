using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.MVC.Models;

namespace SchoolManagement.MVC.Controllers
{
    [Authorize]
    public class LecturesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LecturesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Lectures
        public async Task<IActionResult> Index()
        {
              return _context.Lectures != null ? 
                          View(await _context.Lectures.ToListAsync()) :
                          Problem("Entity set 'ApplicationDbContext.Lectures'  is null.");
        }

        // GET: Lectures/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Lectures == null)
            {
                return NotFound();
            }

            var lectures = await _context.Lectures
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lectures == null)
            {
                return NotFound();
            }

            return View(lectures);
        }

        // GET: Lectures/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lectures/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName")] Lectures lectures)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lectures);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lectures);
        }

        // GET: Lectures/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Lectures == null)
            {
                return NotFound();
            }

            var lectures = await _context.Lectures.FindAsync(id);
            if (lectures == null)
            {
                return NotFound();
            }
            return View(lectures);
        }

        // POST: Lectures/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName")] Lectures lectures)
        {
            if (id != lectures.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lectures);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LecturesExists(lectures.Id))
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
            return View(lectures);
        }

        // GET: Lectures/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Lectures == null)
            {
                return NotFound();
            }

            var lectures = await _context.Lectures
                .FirstOrDefaultAsync(m => m.Id == id);
            if (lectures == null)
            {
                return NotFound();
            }

            return View(lectures);
        }

        // POST: Lectures/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Lectures == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Lectures'  is null.");
            }
            var lectures = await _context.Lectures.FindAsync(id);
            if (lectures != null)
            {
                _context.Lectures.Remove(lectures);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LecturesExists(int id)
        {
          return (_context.Lectures?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
