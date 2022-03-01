#nullable disable

namespace HRSWebAPI.Controllers.PDS
{
    [Route("api/[controller]")]
    [ApiController]
    public class EducationalBackgroundsController : ControllerBase
    {
        private readonly HRISContext _context;

        public EducationalBackgroundsController(HRISContext context)
        {
            _context = context;
        }

        // GET: api/EducationalBackgrounds
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EducationalBackground>>> GetEducationalBackgrounds()
        {
            return await _context.EducationalBackgrounds.ToListAsync();
        }

        // GET: api/EducationalBackgrounds/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EducationalBackground>> GetEducationalBackground(int id)
        {
            var educationalBackground = await _context.EducationalBackgrounds.FindAsync(id);

            if (educationalBackground == null)
            {
                return NotFound();
            }

            return educationalBackground;
        }

        // PUT: api/EducationalBackgrounds/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEducationalBackground(int id, EducationalBackground educationalBackground)
        {
            if (id != educationalBackground.RecordId)
            {
                return BadRequest();
            }

            _context.Entry(educationalBackground).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EducationalBackgroundExists(id))
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

        // POST: api/EducationalBackgrounds
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EducationalBackground>> PostEducationalBackground(EducationalBackground educationalBackground)
        {
            _context.EducationalBackgrounds.Add(educationalBackground);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEducationalBackground", new { id = educationalBackground.RecordId }, educationalBackground);
        }

        // DELETE: api/EducationalBackgrounds/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEducationalBackground(int id)
        {
            var educationalBackground = await _context.EducationalBackgrounds.FindAsync(id);
            if (educationalBackground == null)
            {
                return NotFound();
            }

            _context.EducationalBackgrounds.Remove(educationalBackground);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EducationalBackgroundExists(int id)
        {
            return _context.EducationalBackgrounds.Any(e => e.RecordId == id);
        }
    }
}
