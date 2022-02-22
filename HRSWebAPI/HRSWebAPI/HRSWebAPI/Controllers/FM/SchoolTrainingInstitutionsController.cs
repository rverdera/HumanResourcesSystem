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
    public class SchoolTrainingInstitutionsController : ControllerBase
    {
        private readonly HRISContext _context;

        public SchoolTrainingInstitutionsController(HRISContext context)
        {
            _context = context;
        }

        // GET: api/SchoolTrainingInstitutions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SchoolTrainingInstitution>>> GetSchoolTrainingInstitutions()
        {
            return await _context.SchoolTrainingInstitutions.ToListAsync();
        }

        // GET: api/SchoolTrainingInstitutions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SchoolTrainingInstitution>> GetSchoolTrainingInstitution(int id)
        {
            var schoolTrainingInstitution = await _context.SchoolTrainingInstitutions.FindAsync(id);

            if (schoolTrainingInstitution == null)
            {
                return NotFound();
            }

            return schoolTrainingInstitution;
        }

        // PUT: api/SchoolTrainingInstitutions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSchoolTrainingInstitution(int id, SchoolTrainingInstitution schoolTrainingInstitution)
        {
            if (id != schoolTrainingInstitution.SchoolTrainingInstitutionId)
            {
                return BadRequest();
            }

            _context.Entry(schoolTrainingInstitution).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SchoolTrainingInstitutionExists(id))
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

        // POST: api/SchoolTrainingInstitutions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SchoolTrainingInstitution>> PostSchoolTrainingInstitution(SchoolTrainingInstitution schoolTrainingInstitution)
        {
            _context.SchoolTrainingInstitutions.Add(schoolTrainingInstitution);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetSchoolTrainingInstitution", new { id = schoolTrainingInstitution.SchoolTrainingInstitutionId }, schoolTrainingInstitution);
        }

        // DELETE: api/SchoolTrainingInstitutions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSchoolTrainingInstitution(int id)
        {
            var schoolTrainingInstitution = await _context.SchoolTrainingInstitutions.FindAsync(id);
            if (schoolTrainingInstitution == null)
            {
                return NotFound();
            }

            _context.SchoolTrainingInstitutions.Remove(schoolTrainingInstitution);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool SchoolTrainingInstitutionExists(int id)
        {
            return _context.SchoolTrainingInstitutions.Any(e => e.SchoolTrainingInstitutionId == id);
        }
    }
}
