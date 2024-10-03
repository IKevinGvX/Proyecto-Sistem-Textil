﻿using System;
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
    public class ProveedoresController : ControllerBase
    {
        private readonly ProveedoresDbContext _context;

        public ProveedoresController(ProveedoresDbContext context)
        {
            _context = context;
        }

        // GET: api/Proveedores
        [HttpGet("ListarProveedores")]
        public async Task<ActionResult<IEnumerable<Proveedores>>> GetProveedores()
        {
            return await _context.Proveedores.ToListAsync();
        }

        // GET: api/Proveedores/5
        [HttpGet("SearchByIDProveedores")]
        public async Task<ActionResult<Proveedores>> GetProveedores(int id)
        {
            var proveedores = await _context.Proveedores.FindAsync(id);

            if (proveedores == null)
            {
                return NotFound();
            }

            return proveedores;
        }

        // PUT: api/Proveedores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("actualizarproveedores/{id}")]
        public async Task<IActionResult> PutProveedores(int id, Proveedores proveedores)
        {
            if (id != proveedores.proveedorid)
            {
                return BadRequest();
            }

            _context.Entry(proveedores).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProveedoresExists(id))
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

        // POST: api/Proveedores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost("AgregarProveedores")]
        public async Task<ActionResult<Proveedores>> PostProveedores(Proveedores proveedores)
        {
            _context.Proveedores.Add(proveedores);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProveedores", new { id = proveedores.proveedorid }, proveedores);
        }

        // DELETE: api/Proveedores/5
        [HttpDelete("EliminarProveedores")]
        public async Task<IActionResult> DeleteProveedores(int id)
        {
            var proveedores = await _context.Proveedores.FindAsync(id);
            if (proveedores == null)
            {
                return NotFound();
            }

            _context.Proveedores.Remove(proveedores);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ProveedoresExists(int id)
        {
            return _context.Proveedores.Any(e => e.proveedorid == id);
        }
    }
}
