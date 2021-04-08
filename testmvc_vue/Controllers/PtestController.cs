using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using testmvc_vue.Data;
using testmvc_vue.DTOs;
using testmvc_vue_core.Models;

namespace testmvc_vue.Controllers
{
    /// <summary>
    /// Ptest Controller to test implementation
    /// </summary>
    [ApiController]
    [Route("ptest")]
    public class PtestController : Controller
    {
        private readonly ApplicationDbContext _context;
        private IMapper _mapper;
        public PtestController(ApplicationDbContext context, IMapper mapper)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        /// <summary>
        /// Create TableB entity
        /// </summary>
        /// <param name="model">Request model to create TableB</param>
        /// <returns>Id of created TableB</returns>
        [HttpPost("create")]
        public async Task<int> Create([FromBody]PtestRequest model)
        {
            var tableb = _mapper.Map<Table_B>(model);

            tableb.table_BID = DateTime.Now.Millisecond;
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
