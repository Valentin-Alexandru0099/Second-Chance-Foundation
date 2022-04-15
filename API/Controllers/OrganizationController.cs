using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class OrganizationController : BaseApiController
    {
        private readonly StoreContext _context;
        public OrganizationController(StoreContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Organization>>> GetAllOrganizations()
        {
            return await _context.Organizations.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Organization>> GetOrganization(int id)
        {
            var organization = await _context.Organizations.FindAsync(id);
            if (organization == null) return NotFound();
            return organization;
        }

        

    }
}
