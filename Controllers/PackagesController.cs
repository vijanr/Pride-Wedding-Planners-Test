using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PrideWeddingPlanners.Models;

namespace PrideWeddingPlanners.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PackagesController : ControllerBase
    {
        private readonly WeddingDBContext _context;

        public PackagesController(WeddingDBContext context)
        {
            _context = context;
        }

        // GET: api/Packages
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Packages>>> GetPackagesTable()
        {
            return await _context.PackagesTable.ToListAsync();
        }

        // GET: api/Packages/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Packages>> GetPackages(int id)
        {
            var packages = await _context.PackagesTable.FindAsync(id);

            if (packages == null)
            {
                return NotFound();
            }

            return packages;
        }

        // PUT: api/Packages/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPackages(int id, Packages packages)
        {
            if (id != packages.ID)
            {
                return BadRequest();
            }

            _context.Entry(packages).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PackagesExists(id))
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

        // POST: api/Packages
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Packages>> PostPackages(Packages packages)
        {
            _context.PackagesTable.Add(packages);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPackages", new { id = packages.ID }, packages);
        }

        // DELETE: api/Packages/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Packages>> DeletePackages(int id)
        {
            var packages = await _context.PackagesTable.FindAsync(id);
            if (packages == null)
            {
                return NotFound();
            }

            _context.PackagesTable.Remove(packages);
            await _context.SaveChangesAsync();

            return packages;
        }

        private bool PackagesExists(int id)
        {
            return _context.PackagesTable.Any(e => e.ID == id);
        }
    }
}
