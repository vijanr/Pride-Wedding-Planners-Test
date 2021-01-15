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
    public class Vendor_AccountController : ControllerBase
    {
        private readonly WeddingDBContext _context;

        public Vendor_AccountController(WeddingDBContext context)
        {
            _context = context;
        }

        // GET: api/Vendor_Account
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vendor_Account>>> GetVendorAccountTable()
        {
            return await _context.VendorAccountTable.ToListAsync();
        }

        // GET: api/Vendor_Account/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vendor_Account>> GetVendor_Account(int id)
        {
            var vendor_Account = await _context.VendorAccountTable.FindAsync(id);

            if (vendor_Account == null)
            {
                return NotFound();
            }

            return vendor_Account;
        }

        // PUT: api/Vendor_Account/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVendor_Account(int id, Vendor_Account vendor_Account)
        {
            if (id != vendor_Account.ID)
            {
                return BadRequest();
            }

            _context.Entry(vendor_Account).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Vendor_AccountExists(id))
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

        // POST: api/Vendor_Account
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Vendor_Account>> PostVendor_Account(Vendor_Account vendor_Account)
        {
            _context.VendorAccountTable.Add(vendor_Account);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVendor_Account", new { id = vendor_Account.ID }, vendor_Account);
        }

        // DELETE: api/Vendor_Account/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Vendor_Account>> DeleteVendor_Account(int id)
        {
            var vendor_Account = await _context.VendorAccountTable.FindAsync(id);
            if (vendor_Account == null)
            {
                return NotFound();
            }

            _context.VendorAccountTable.Remove(vendor_Account);
            await _context.SaveChangesAsync();

            return vendor_Account;
        }

        private bool Vendor_AccountExists(int id)
        {
            return _context.VendorAccountTable.Any(e => e.ID == id);
        }
    }
}
