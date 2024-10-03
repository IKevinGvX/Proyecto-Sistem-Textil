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
    public class EmpleadosController : ControllerBase
    {
        private readonly EmpleadosDbContext _context;

        public EmpleadosController(EmpleadosDbContext context)
        {
            _context = context;
        }

        // GET: api/Empleados
        [HttpGet("ListarEmpleados")]
        public async Task<ActionResult<IEnumerable<Empleados>>> GetEmpleados()
        {
            return await _context.Empleados.ToListAsync();
        }

        // GET: api/Empleados/5
        [HttpGet("SearchByIDEmpleados")]
        public async Task<ActionResult<Empleados>> GetEmpleados(int id)
        {
            var empleados = await _context.Empleados.FindAsync(id);

            if (empleados == null)
            {
                return NotFound();
            }

            return empleados;
        }

        // PUT: api/Empleados/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("actualizarempleados/{id}")]
        public async Task<IActionResult> PutEmpleados(int id, Empleados empleados)
        {
            if (id != empleados.empleadoid)
            {
                return BadRequest();
            }

            _context.Entry(empleados).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmpleadosExists(id))
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

        // POST: api/Empleados
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("AgregarEmpleados")]
        public async Task<ActionResult<Empleados>> PostEmpleados(Empleados empleados)
        {
            _context.Empleados.Add(empleados);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmpleados", new { id = empleados.empleadoid }, empleados);
        }

        // DELETE: api/Empleados/5
        [HttpDelete("EliminarEmpleados")]
        public async Task<IActionResult> DeleteEmpleados(int id)
        {
            var empleados = await _context.Empleados.FindAsync(id);
            if (empleados == null)
            {
                return NotFound();
            }

            _context.Empleados.Remove(empleados);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmpleadosExists(int id)
        {
            return _context.Empleados.Any(e => e.empleadoid == id);
        }
    }
}
