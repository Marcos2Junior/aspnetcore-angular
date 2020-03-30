using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AspNetCoreAngular.Data;
using AspNetCoreAngular.Model;

namespace AspNetCoreAngular.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventoesController : ControllerBase
    {
        private readonly AspNetCoreAngularContext _context;

        public EventoesController(AspNetCoreAngularContext context)
        {
            _context = context;
        }

        // GET: api/Eventoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Evento>>> GetEvento()
        {
            return await _context.Evento.ToListAsync();
        }

        // GET: api/Eventoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Evento>> GetEvento(int id)
        {
            var evento = await _context.Evento.FindAsync(id);

            if (evento == null)
            {
                return NotFound();
            }

            return evento;
        }

        // PUT: api/Eventoes/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEvento(int id, Evento evento)
        {
            if (id != evento.EventoId)
            {
                return BadRequest();
            }

            _context.Entry(evento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Eventoes
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Evento>> PostEvento(Evento evento)
        {
            _context.Evento.Add(evento);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEvento", new { id = evento.EventoId }, evento);
        }

        // DELETE: api/Eventoes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Evento>> DeleteEvento(int id)
        {
            var evento = await _context.Evento.FindAsync(id);
            if (evento == null)
            {
                return NotFound();
            }

            _context.Evento.Remove(evento);
            await _context.SaveChangesAsync();

            return evento;
        }

        private bool EventoExists(int id)
        {
            return _context.Evento.Any(e => e.EventoId == id);
        }
    }
}
