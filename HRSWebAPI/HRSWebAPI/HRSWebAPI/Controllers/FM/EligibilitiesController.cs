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

namespace HRSWebAPI.Controllers.FM
{
    [Route("api/[controller]")]
    [ApiController]
    public class EligibilitiesController : ControllerBase
    {
        private readonly HRISContext _context;

        public EligibilitiesController(HRISContext context)
        {
            _context = context;
        }

        // GET: api/Eligibilities
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Eligibility>>> GetEligibilities()
        {
            return await _context.Eligibilities.ToListAsync();
        }

        // GET: api/Eligibilities/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Eligibility>> GetEligibility(int id)
        {
            var eligibility = await _context.Eligibilities.FindAsync(id);

            if (eligibility == null)
            {
                return NotFound();
            }

            return eligibility;
        }

        // PUT: api/Eligibilities/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEligibility(int id, Eligibility eligibility)
        {
            if (id != eligibility.EligibilityId)
            {
                return BadRequest();
            }

            _context.Entry(eligibility).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EligibilityExists(id))
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

        // POST: api/Eligibilities
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Eligibility>> PostEligibility(Eligibility eligibility)
        {
            _context.Eligibilities.Add(eligibility);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEligibility", new { id = eligibility.EligibilityId }, eligibility);
        }

        // DELETE: api/Eligibilities/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEligibility(int id)
        {
            var eligibility = await _context.Eligibilities.FindAsync(id);
            if (eligibility == null)
            {
                return NotFound();
            }

            _context.Eligibilities.Remove(eligibility);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EligibilityExists(int id)
        {
            return _context.Eligibilities.Any(e => e.EligibilityId == id);
        }
    }
}
