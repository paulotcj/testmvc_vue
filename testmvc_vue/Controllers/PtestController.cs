using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using testmvc_vue.Data;
using testmvc_vue_core.Models;

namespace testmvc_vue.Controllers
{
    [ApiController]
    [Route("ptest")]
    public class PtestController : Controller
    {
        private readonly ApplicationDbContext _context;
        public PtestController(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        [HttpPost("create")]
        public async Task<int> Create()
        {
            var tableb = new Table_B
            {
                table_BID = 1,
                Col1 = "1"
            };
            await _context.Table_B.AddAsync(tableb);

            await _context.SaveChangesAsync();

            return tableb.table_BID;
        }

        [HttpPost("grid")]
        public async Task<IEnumerable<Table_B>> GridData(CancellationToken cancellationToken)
        {
            var tableb = new Table_B
            {
                table_BID = 1,
                Col1 = "1"
            };
            var data = await _context.Table_B.Where(i => !string.IsNullOrEmpty(i.Col1)).ToListAsync(cancellationToken);

            return data;
        }
    }
}
