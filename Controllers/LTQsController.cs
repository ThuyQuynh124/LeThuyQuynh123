using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LeThuyQuynh123.Models;

namespace LeThuyQuynh123.Controllers
{
    public class LTQsController : Controller
    {
        private readonly ApplicationDBContext _context;

        public LTQsController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: LTQs
        public async Task<IActionResult> Index()
        {
            return View(await _context.LTQ.ToListAsync());
        }

        // GET: LTQs/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lTQ = await _context.LTQ
                .FirstOrDefaultAsync(m => m.LTQId == id);
            if (lTQ == null)
            {
                return NotFound();
            }

            return View(lTQ);
        }

        // GET: LTQs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LTQs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LTQId,LTQName,LTQGender")] LTQ lTQ)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lTQ);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lTQ);
        }

        // GET: LTQs/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lTQ = await _context.LTQ.FindAsync(id);
            if (lTQ == null)
            {
                return NotFound();
            }
            return View(lTQ);
        }

        // POST: LTQs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("LTQId,LTQName,LTQGender")] LTQ lTQ)
        {
            if (id != lTQ.LTQId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lTQ);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LTQExists(lTQ.LTQId))
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
            return View(lTQ);
        }

        // GET: LTQs/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lTQ = await _context.LTQ
                .FirstOrDefaultAsync(m => m.LTQId == id);
            if (lTQ == null)
            {
                return NotFound();
            }

            return View(lTQ);
        }

        // POST: LTQs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var lTQ = await _context.LTQ.FindAsync(id);
            _context.LTQ.Remove(lTQ);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LTQExists(string id)
        {
            return _context.LTQ.Any(e => e.LTQId == id);
        }
    }
}
