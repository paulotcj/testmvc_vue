using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using testmvc_vue.Data;
using testmvc_vue_core.Models;

namespace testmvc_vue.Controllers
{
    public class TestAsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TestAsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TestAs
        public async Task<IActionResult> Index()
        {
            return View(await _context.TestA.ToListAsync());
        }

        // GET: TestAs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testA = await _context.TestA
                .FirstOrDefaultAsync(m => m.TestAID == id);
            if (testA == null)
            {
                return NotFound();
            }

            return View(testA);
        }

        // GET: TestAs/Create
        public IActionResult Create()
        {
            
            return View();
        }

        // POST: TestAs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("TestAID,DocumentCode")] TestA testA)
        {
            if (ModelState.IsValid)
            {
                _context.Add(testA);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(testA);
        }

        // GET: TestAs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testA = await _context.TestA.FindAsync(id);
            if (testA == null)
            {
                return NotFound();
            }
            return View(testA);
        }

        // POST: TestAs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("TestAID,DocumentCode")] TestA testA)
        {
            if (id != testA.TestAID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(testA);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TestAExists(testA.TestAID))
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
            return View(testA);
        }

        // GET: TestAs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var testA = await _context.TestA
                .FirstOrDefaultAsync(m => m.TestAID == id);
            if (testA == null)
            {
                return NotFound();
            }

            return View(testA);
        }

        // POST: TestAs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var testA = await _context.TestA.FindAsync(id);
            _context.TestA.Remove(testA);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TestAExists(int id)
        {
            return _context.TestA.Any(e => e.TestAID == id);
        }
    }
}
