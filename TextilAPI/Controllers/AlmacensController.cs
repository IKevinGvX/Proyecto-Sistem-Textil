using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AlmacenSwagger.Models;
using TextilAPI.Models;

namespace AlmacenSwagger.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlmacensController : ControllerBase
    {
        private readonly AlmacenContext _context;

        public AlmacensController(AlmacenContext context)
        {
            _context = context;
        }

        // GET: api/Almacens
        [HttpGet("ListarAlmacen")]
        public async Task<ActionResult<IEnumerable<Almacen>>> GetAlmacen()
        {
            return await _context.Almacen.ToListAsync();
        }

        // GET: api/Almacens/5
        [HttpGet("SearchByIDAlmacen{id}")]
        public async Task<ActionResult<Almacen>> GetAlmacen(int id)
        {
            var almacen = await _context.Almacen.FindAsync(id);

            if (almacen == null)
            {
                return NotFound();
            }

            return almacen;
        }

        // PUT: api/Almacens/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("ActualizarAlmacen{id}")]
        public async Task<IActionResult> PutAlmacen(int id, Almacen almacen)
        {
            if (id != almacen.almacenid)
            {
                return BadRequest();
            }

            _context.Entry(almacen).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlmacenExists(id))
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

        // POST: api/Almacens
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("AgregarAlmacen")]
        public async Task<ActionResult<Almacen>> PostAlmacen(Almacen almacen)
        {
            _context.Almacen.Add(almacen);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAlmacen", new { id = almacen.almacenid }, almacen);
        }

        // DELETE: api/Almacens/5
        [HttpDelete("EliminarAlmacen    {id}")]
        public async Task<IActionResult> DeleteAlmacen(int id)
        {
            var almacen = await _context.Almacen.FindAsync(id);
            if (almacen == null)
            {
                return NotFound();
            }

            _context.Almacen.Remove(almacen);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AlmacenExists(int id)
        {
            return _context.Almacen.Any(e => e.almacenid == id);
        }
    }
}
