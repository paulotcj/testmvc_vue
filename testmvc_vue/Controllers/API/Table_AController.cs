using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using testmvc_vue.Data;
using testmvc_vue_core.Models;
using Microsoft.AspNetCore.Authorization;

namespace testmvc_vue.Controllers.API
{

    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    
    public class Table_AController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public Table_AController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Table_A
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Table_A>>> GetTable_A()
        {
            return await _context.Table_A.ToListAsync();
        }

        // GET: api/Table_A/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Table_A>> GetTable_A(int id)
        {
            var table_A = await _context.Table_A.FindAsync(id);

            if (table_A == null)
            {
                return NotFound();
            }

            return table_A;
        }

        // PUT: api/Table_A/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTable_A(int id, Table_A table_A)
        {
            if (id != table_A.table_AID)
            {
                return BadRequest();
            }

            _context.Entry(table_A).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Table_AExists(id))
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

        // POST: api/Table_A
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Table_A>> PostTable_A(Table_A table_A)
        {
            _context.Table_A.Add(table_A);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTable_A", new { id = table_A.table_AID }, table_A);
        }

        // DELETE: api/Table_A/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTable_A(int id)
        {
            var table_A = await _context.Table_A.FindAsync(id);
            if (table_A == null)
            {
                return NotFound();
            }

            _context.Table_A.Remove(table_A);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Table_AExists(int id)
        {
            return _context.Table_A.Any(e => e.table_AID == id);
        }
    }
}
