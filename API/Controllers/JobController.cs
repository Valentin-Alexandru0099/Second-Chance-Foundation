using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class JobController : BaseApiController
    {
        private readonly StoreContext _context;
        public JobController(StoreContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Job>>> GetAllJobs()
        {
            return await _context.Jobs.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Job>> GetJob(int id)
        {
            return await _context.Jobs.FindAsync(id);
        }

    }
}
