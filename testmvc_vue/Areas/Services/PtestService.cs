using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using testmvc_vue.Data;
using testmvc_vue_core.Models;

namespace testmvc_vue.Areas.Services
{
    public interface IPtestService
    {
        Task<Table_B> Create(Table_B item);
        Task<Table_B> Update(Table_B item);
        Task Delete(int id);
        Task<IEnumerable<Table_B>> GetGridData(CancellationToken cancellationToken);
    }

    public class PtestService : IPtestService
    {
        private readonly ApplicationDbContext _context;

        public PtestService(ApplicationDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public async Task<Table_B> Create(Table_B item)
        {
            item.table_BID = DateTime.Now.Millisecond;
            item.Col2 = DateTime.UtcNow.ToString();
            ///....
            ///another bindings
            ///


            await _context.Table_B.AddAsync(item);

            await _context.SaveChangesAsync();

            return item;
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Table_B>> GetGridData(CancellationToken cancellationToken)
        {
            return await _context.Table_B.Where(i => !string.IsNullOrEmpty(i.Col1)).ToListAsync(cancellationToken);
        }

        public Task<Table_B> Update(Table_B item)
        {
            throw new NotImplementedException();
        }
    }
}
