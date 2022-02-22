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
    public class EligibilityCategoriesController : ControllerBase
    {
        private readonly HRISContext _context;

        public EligibilityCategoriesController(HRISContext context)
        {
            _context = context;
        }

        // GET: api/EligibilityCategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EligibilityCategory>>> GetEligibilityCategories()
        {
            return await _context.EligibilityCategories.ToListAsync();
        }

        // GET: api/EligibilityCategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EligibilityCategory>> GetEligibilityCategory(int id)
        {
            var eligibilityCategory = await _context.EligibilityCategories.FindAsync(id);

            if (eligibilityCategory == null)
            {
                return NotFound();
            }

            return eligibilityCategory;
        }

        // PUT: api/EligibilityCategories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEligibilityCategory(int id, EligibilityCategory eligibilityCategory)
        {
            if (id != eligibilityCategory.EligibilityCategoryId)
            {
                return BadRequest();
            }

            _context.Entry(eligibilityCategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EligibilityCategoryExists(id))
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

        // POST: api/EligibilityCategories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EligibilityCategory>> PostEligibilityCategory(EligibilityCategory eligibilityCategory)
        {
            _context.EligibilityCategories.Add(eligibilityCategory);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (EligibilityCategoryExists(eligibilityCategory.EligibilityCategoryId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetEligibilityCategory", new { id = eligibilityCategory.EligibilityCategoryId }, eligibilityCategory);
        }

        // DELETE: api/EligibilityCategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEligibilityCategory(int id)
        {
            var eligibilityCategory = await _context.EligibilityCategories.FindAsync(id);
            if (eligibilityCategory == null)
            {
                return NotFound();
            }

            _context.EligibilityCategories.Remove(eligibilityCategory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EligibilityCategoryExists(int id)
        {
            return _context.EligibilityCategories.Any(e => e.EligibilityCategoryId == id);
        }
    }
}
