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
    public class Table_AController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Table_AController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Table_A
        public async Task<IActionResult> Index()
        {
            var a = await _context.Table_A.ToListAsync();
            return View(a);
        }

        // GET: Table_A/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var table_A = await _context.Table_A
                .FirstOrDefaultAsync(m => m.table_AID == id);
            if (table_A == null)
            {
                return NotFound();
            }

            return View(table_A);
        }

        // GET: Table_A/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Table_A/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("table_AID,Col1,Col2,Col3,Col4")] Table_A table_A)
        {
            if (ModelState.IsValid)
            {
                _context.Add(table_A);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(table_A);
        }

        // GET: Table_A/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var table_A = await _context.Table_A.FindAsync(id);
            if (table_A == null)
            {
                return NotFound();
            }
            return View(table_A);
        }

        // POST: Table_A/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("table_AID,Col1,Col2,Col3,Col4")] Table_A table_A)
        {
            if (id != table_A.table_AID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(table_A);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Table_AExists(table_A.table_AID))
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
            return View(table_A);
        }

        // GET: Table_A/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var table_A = await _context.Table_A
                .FirstOrDefaultAsync(m => m.table_AID == id);
            if (table_A == null)
            {
                return NotFound();
            }

            return View(table_A);
        }

        // POST: Table_A/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var table_A = await _context.Table_A.FindAsync(id);
            _context.Table_A.Remove(table_A);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Table_AExists(int id)
        {
            return _context.Table_A.Any(e => e.table_AID == id);
        }
    }
}
