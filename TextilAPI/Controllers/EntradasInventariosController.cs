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
    public class EntradasInventariosController : ControllerBase
    {
        private readonly EntradasInventarioDbContext _context;

        public EntradasInventariosController(EntradasInventarioDbContext context)
        {
            _context = context;
        }

        // GET: api/EntradasInventarios
        [HttpGet("ListarEntradasInventario")]
        public async Task<ActionResult<IEnumerable<EntradasInventario>>> GetEntradasInventario()
        {
            return await _context.EntradasInventario.ToListAsync();
        }

        // GET: api/EntradasInventarios/5
        [HttpGet("SearchByIDEntradas")]
        public async Task<ActionResult<EntradasInventario>> GetEntradasInventario(int id)
        {
            var entradasInventario = await _context.EntradasInventario.FindAsync(id);

            if (entradasInventario == null)
            {
                return NotFound();
            }

            return entradasInventario;
        }

        // PUT: api/EntradasInventarios/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("actualizarentradas/{id}")]
        public async Task<IActionResult> PutEntradasInventario(int id, EntradasInventario entradasInventario)
        {
            if (id != entradasInventario.almacenid)
            {
                return BadRequest();
            }

            _context.Entry(entradasInventario).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntradasInventarioExists(id))
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

        // POST: api/EntradasInventarios
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("AgregarEntradas")]
        public async Task<ActionResult<EntradasInventario>> PostEntradasInventario(EntradasInventario entradasInventario)
        {
            _context.EntradasInventario.Add(entradasInventario);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEntradasInventario", new { id = entradasInventario.almacenid }, entradasInventario);
        }

        // DELETE: api/EntradasInventarios/5
        [HttpDelete("EliminarEntradas")]
        public async Task<IActionResult> DeleteEntradasInventario(int id)
        {
            var entradasInventario = await _context.EntradasInventario.FindAsync(id);
            if (entradasInventario == null)
            {
                return NotFound();
            }

            _context.EntradasInventario.Remove(entradasInventario);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EntradasInventarioExists(int id)
        {
            return _context.EntradasInventario.Any(e => e.almacenid == id);
        }
    }
}
