using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TokenAuthenticationWebApi.Data;
using Microsoft.EntityFrameworkCore;

namespace TokenAuthenticationWebApi.Controllers
{
    
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class BookController: ControllerBase
    {
        private readonly TokenDbContext _context;
        public BookController(TokenDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetBooks()
        {
            var data = await _context.TblBooks.ToListAsync();
            return Ok(data);
        }
    }
}
