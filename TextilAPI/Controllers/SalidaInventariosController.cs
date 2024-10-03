using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TextilSwagger.Models;

namespace TextilSwagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalidaInventariosController : ControllerBase
    {
        private readonly SalidaInventarioDbContext _context;

        public SalidaInventariosController(SalidaInventarioDbContext context)
        {
            _context = context;
        }

        // GET: api/SalidaInventarios
        [HttpGet("ListarSalidas")]
        public async Task<ActionResult<IEnumerable<SalidaInventario>>> GetSalidaInventario()
        {
            return await _context.SalidasInventario.ToListAsync();
        }

        // GET: api/SalidaInventarios/5
        [HttpGet("SearchByIDSalidas")]
        public async Task<ActionResult<SalidaInventario>> GetSalidaInventario(int id)
        {
            var salidaInventario = await _context.SalidasInventario.FindAsync(id);

            if (salidaInventario == null)
            {
                return NotFound();
            }

            return salidaInventario;
        }

        // PUT: api/SalidaInventarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("actualizarsalidas/{id}")]
        public async Task<IActionResult> PutSalidaInventario(int id, SalidaInventario salidaInventario)
        {
            if (id != salidaInventario.salidaid)
            {
                return BadRequest();
            }

            _context.Entry(salidaInventario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SalidaInventarioExists(id))
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

        // POST: api/SalidaInventarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("AgregarSalidas")]
        public async Task<ActionResult<SalidaInventario>> PostSalidaInventario(SalidaInventario salidaInventario)
        {
            _context.SalidasInventario.Add(salidaInventario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSalidaInventario", new { id = salidaInventario.salidaid }, salidaInventario);
        }

        // DELETE: api/SalidaInventarios/5
        [HttpDelete("EliminarSalidas")]
        public async Task<IActionResult> DeleteSalidaInventario(int id)
        {
            var salidaInventario = await _context.SalidasInventario.FindAsync(id);
            if (salidaInventario == null)
            {
                return NotFound();
            }

            _context.SalidasInventario.Remove(salidaInventario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SalidaInventarioExists(int id)
        {
            return _context.SalidasInventario.Any(e => e.salidaid == id);
        }
    }
}
