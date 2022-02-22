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
    public class FamilyBackgroundsController : ControllerBase
    {
        private readonly HRISContext _context;

        public FamilyBackgroundsController(HRISContext context)
        {
            _context = context;
        }

        // GET: api/FamilyBackgrounds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FamilyBackground>>> GetFamilyBackgrounds()
        {
            return await _context.FamilyBackgrounds.ToListAsync();
        }

        // GET: api/FamilyBackgrounds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FamilyBackground>> GetFamilyBackground(int id)
        {
            var familyBackground = await _context.FamilyBackgrounds.FindAsync(id);

            if (familyBackground == null)
            {
                return NotFound();
            }

            return familyBackground;
        }

        // PUT: api/FamilyBackgrounds/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFamilyBackground(int id, FamilyBackground familyBackground)
        {
            if (id != familyBackground.RecordId)
            {
                return BadRequest();
            }

            _context.Entry(familyBackground).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FamilyBackgroundExists(id))
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

        // POST: api/FamilyBackgrounds
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<FamilyBackground>> PostFamilyBackground(FamilyBackground familyBackground)
        {
            _context.FamilyBackgrounds.Add(familyBackground);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFamilyBackground", new { id = familyBackground.RecordId }, familyBackground);
        }

        // DELETE: api/FamilyBackgrounds/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFamilyBackground(int id)
        {
            var familyBackground = await _context.FamilyBackgrounds.FindAsync(id);
            if (familyBackground == null)
            {
                return NotFound();
            }

            _context.FamilyBackgrounds.Remove(familyBackground);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool FamilyBackgroundExists(int id)
        {
            return _context.FamilyBackgrounds.Any(e => e.RecordId == id);
        }
    }
}
