using AccessControl.API.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AccessControl.API.Controllers
{
    [ApiController]
    [Route("/api/tickets")]
    public class TicketsController : ControllerBase
    {
        private readonly DataContext _context;

        public TicketsController(DataContext context)
        {
            _context = context;
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult> GetAsync(int id)
        {
            var ticket = await _context.mvTickets.FirstOrDefaultAsync(x => x.Id == id);
            if (ticket == null)
            {
                return NotFound();
            }

            return Ok(ticket);
        }
    }
}
