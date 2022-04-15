using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    public class ArticleController
    {
        private readonly StoreContext _context;
        public ArticleController(StoreContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Article>>> GetAllArticles()
        {
            return await _context.Articles.ToListAsync();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<Article>> GetArticle(int id)
        {
            return await _context.Articles.FindAsync(id);
        }
    }
}
