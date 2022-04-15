using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class MeetController : BaseApiController
    {
        private readonly StoreContext _context;
        public MeetController(StoreContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Meet>>> GetAllMeets()
        {
            return await _context.Meets.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Meet>> GetJob(int id)
        {
            return await _context.Meets.FindAsync(id);
        }
    }
}
