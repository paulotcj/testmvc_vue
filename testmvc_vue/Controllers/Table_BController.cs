using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using testmvc_vue.Data;
using testmvc_vue.Models;

namespace testmvc_vue.Controllers
{
    public class Table_BController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Table_BController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Table_B
        public async Task<IActionResult> Index()
        {
            return View(await _context.Table_B.ToListAsync());
        }

        // GET: Table_B/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var table_B = await _context.Table_B
                .FirstOrDefaultAsync(m => m.table_BID == id);
            if (table_B == null)
            {
                return NotFound();
            }

            return View(table_B);
        }

        // GET: Table_B/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Table_B/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("table_BID,Col1,Col2,Col3,Col4")] Table_B table_B)
        {
            if (ModelState.IsValid)
            {
                _context.Add(table_B);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(table_B);
        }

        // GET: Table_B/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var table_B = await _context.Table_B.FindAsync(id);
            if (table_B == null)
            {
                return NotFound();
            }
            return View(table_B);
        }

        // POST: Table_B/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("table_BID,Col1,Col2,Col3,Col4")] Table_B table_B)
        {
            if (id != table_B.table_BID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(table_B);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Table_BExists(table_B.table_BID))
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
            return View(table_B);
        }

        // GET: Table_B/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var table_B = await _context.Table_B
                .FirstOrDefaultAsync(m => m.table_BID == id);
            if (table_B == null)
            {
                return NotFound();
            }

            return View(table_B);
        }

        // POST: Table_B/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var table_B = await _context.Table_B.FindAsync(id);
            _context.Table_B.Remove(table_B);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Table_BExists(int id)
        {
            return _context.Table_B.Any(e => e.table_BID == id);
        }
    }
}
