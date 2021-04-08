using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testmvc_vue.Data;
using testmvc_vue_core.Models;


namespace testmvc_vue.Controllers.API
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class Table_BController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Table_BController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Table_B
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Table_B>>> GetTable_B()
        {
            return await _context.Table_B.ToListAsync();
        }

        // GET: api/Table_B/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Table_B>> GetTable_B(int id)
        {
            var table_B = await _context.Table_B.FindAsync(id);

            if (table_B == null)
            {
                return NotFound();
            }

            return table_B;
        }

        // PUT: api/Table_B/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTable_B(int id, Table_B table_B)
        {
            if (id != table_B.table_BID)
            {
                return BadRequest();
            }

            _context.Entry(table_B).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Table_BExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Table_B
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Table_B>> PostTable_B(Table_B table_B)
        {
            _context.Table_B.Add(table_B);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTable_B", new { id = table_B.table_BID }, table_B);
        }

        // DELETE: api/Table_B/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTable_B(int id)
        {
            var table_B = await _context.Table_B.FindAsync(id);
            if (table_B == null)
            {
                return NotFound();
            }

            _context.Table_B.Remove(table_B);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Table_BExists(int id)
        {
            return _context.Table_B.Any(e => e.table_BID == id);
        }
    }
}
