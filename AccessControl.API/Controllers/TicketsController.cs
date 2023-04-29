using AccessControl.API.Data;
using AccessControl.Shared.Entities;
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

        [HttpPut]
        public async Task<ActionResult> PutAsync(MvTicket ticket)
        {
            try
            {
                _context.Update(ticket);
                await _context.SaveChangesAsync();
                return Ok(ticket);
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException!.Message.Contains("duplicate"))
                {
                    return BadRequest("Ya existe una categoría con el mismo nombre.");
                }
                return BadRequest(ex.InnerException.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
