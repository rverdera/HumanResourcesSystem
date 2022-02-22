#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HRSWebAPI.Data;
using HRSWebAPI.Models;

namespace HRSWebAPI.Controllers.PDS
{
    [Route("api/[controller]")]
    [ApiController]
    public class CivilServiceEligibilitiesController : ControllerBase
    {
        private readonly HRISContext _context;

        public CivilServiceEligibilitiesController(HRISContext context)
        {
            _context = context;
        }

        // GET: api/CivilServiceEligibilities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CivilServiceEligibility>>> GetCivilServiceEligibilities()
        {
            return await _context.CivilServiceEligibilities.ToListAsync();
        }

        // GET: api/CivilServiceEligibilities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CivilServiceEligibility>> GetCivilServiceEligibility(int id)
        {
            var civilServiceEligibility = await _context.CivilServiceEligibilities.FindAsync(id);

            if (civilServiceEligibility == null)
            {
                return NotFound();
            }

            return civilServiceEligibility;
        }

        // PUT: api/CivilServiceEligibilities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCivilServiceEligibility(int id, CivilServiceEligibility civilServiceEligibility)
        {
            if (id != civilServiceEligibility.RecordId)
            {
                return BadRequest();
            }

            _context.Entry(civilServiceEligibility).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CivilServiceEligibilityExists(id))
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

        // POST: api/CivilServiceEligibilities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CivilServiceEligibility>> PostCivilServiceEligibility(CivilServiceEligibility civilServiceEligibility)
        {
            _context.CivilServiceEligibilities.Add(civilServiceEligibility);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCivilServiceEligibility", new { id = civilServiceEligibility.RecordId }, civilServiceEligibility);
        }

        // DELETE: api/CivilServiceEligibilities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCivilServiceEligibility(int id)
        {
            var civilServiceEligibility = await _context.CivilServiceEligibilities.FindAsync(id);
            if (civilServiceEligibility == null)
            {
                return NotFound();
            }

            _context.CivilServiceEligibilities.Remove(civilServiceEligibility);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CivilServiceEligibilityExists(int id)
        {
            return _context.CivilServiceEligibilities.Any(e => e.RecordId == id);
        }
    }
}
