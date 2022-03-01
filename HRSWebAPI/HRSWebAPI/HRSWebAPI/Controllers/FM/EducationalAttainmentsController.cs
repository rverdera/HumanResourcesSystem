#nullable disable

namespace HRSWebAPI.Controllers.FM
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationalAttainmentsController : ControllerBase
    {
        private readonly HRISContext _context;

        public EducationalAttainmentsController(HRISContext context)
        {
            _context = context;
        }

        // GET: api/EducationalAttainments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EducationalAttainment>>> GetEducationalAttainments()
        {
            return await _context.EducationalAttainments.ToListAsync();
        }

        // GET: api/EducationalAttainments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EducationalAttainment>> GetEducationalAttainment(int id)
        {
            var educationalAttainment = await _context.EducationalAttainments.FindAsync(id);

            if (educationalAttainment == null)
            {
                return NotFound();
            }

            return educationalAttainment;
        }

        // PUT: api/EducationalAttainments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEducationalAttainment(int id, EducationalAttainment educationalAttainment)
        {
            if (id != educationalAttainment.EducationalAttainmentId)
            {
                return BadRequest();
            }

            _context.Entry(educationalAttainment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EducationalAttainmentExists(id))
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

        // POST: api/EducationalAttainments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EducationalAttainment>> PostEducationalAttainment(EducationalAttainment educationalAttainment)
        {
            _context.EducationalAttainments.Add(educationalAttainment);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEducationalAttainment", new { id = educationalAttainment.EducationalAttainmentId }, educationalAttainment);
        }

        // DELETE: api/EducationalAttainments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEducationalAttainment(int id)
        {
            var educationalAttainment = await _context.EducationalAttainments.FindAsync(id);
            if (educationalAttainment == null)
            {
                return NotFound();
            }

            _context.EducationalAttainments.Remove(educationalAttainment);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EducationalAttainmentExists(int id)
        {
            return _context.EducationalAttainments.Any(e => e.EducationalAttainmentId == id);
        }
    }
}
