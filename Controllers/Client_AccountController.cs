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
    public class Client_AccountController : ControllerBase
    {
        private readonly WeddingDBContext _context;

        public Client_AccountController(WeddingDBContext context)
        {
            _context = context;
        }

        // GET: api/Client_Account
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Client_Account>>> GetClientAccountTable()
        {
            return await _context.ClientAccountTable.ToListAsync();
        }

        // GET: api/Client_Account/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Client_Account>> GetClient_Account(int id)
        {
            var client_Account = await _context.ClientAccountTable.FindAsync(id);

            if (client_Account == null)
            {
                return NotFound();
            }

            return client_Account;
        }

        // PUT: api/Client_Account/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutClient_Account(int id, Client_Account client_Account)
        {
            if (id != client_Account.ID)
            {
                return BadRequest();
            }

            _context.Entry(client_Account).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Client_AccountExists(id))
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

        // POST: api/Client_Account
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Client_Account>> PostClient_Account(Client_Account client_Account)
        {
            _context.ClientAccountTable.Add(client_Account);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetClient_Account", new { id = client_Account.ID }, client_Account);
        }

        // DELETE: api/Client_Account/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Client_Account>> DeleteClient_Account(int id)
        {
            var client_Account = await _context.ClientAccountTable.FindAsync(id);
            if (client_Account == null)
            {
                return NotFound();
            }

            _context.ClientAccountTable.Remove(client_Account);
            await _context.SaveChangesAsync();

            return client_Account;
        }

        private bool Client_AccountExists(int id)
        {
            return _context.ClientAccountTable.Any(e => e.ID == id);
        }
    }
}
