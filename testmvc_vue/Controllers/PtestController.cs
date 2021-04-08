using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using testmvc_vue.Areas.Services;
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
        private readonly IPtestService _ptestService;
        private IMapper _mapper;
        public PtestController(IPtestService ptestService, IMapper mapper)
        {
            _ptestService = ptestService ?? throw new ArgumentNullException(nameof(ptestService));
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
            var savedItem = await _ptestService.Create(_mapper.Map<Table_B>(model));

            return savedItem.table_BID;
        }

        /// <summary>
        /// Get Grid data of tableB items
        /// </summary>
        /// <param name="cancellationToken"></param>
        /// <returns>List of tableB items</returns>
        [HttpPost("grid")]
        public async Task<IEnumerable<Table_B>> GridData(CancellationToken cancellationToken)
        {
            return await _ptestService.GetGridData(cancellationToken);
        }
    }
}
