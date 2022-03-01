#nullable disable

namespace HRSWebAPI.Controllers.FM
{
    [Route("api/[controller]")]
    [ApiController]
    public class DegreeCoursesController : ControllerBase
    {
        private readonly HRISContext _context;

        public DegreeCoursesController(HRISContext context)
        {
            _context = context;
        }

        // GET: api/DegreeCourses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DegreeCourse>>> GetDegreeCourses()
        {
            return await _context.DegreeCourses.ToListAsync();
        }

        // GET: api/DegreeCourses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DegreeCourse>> GetDegreeCourse(int id)
        {
            var degreeCourse = await _context.DegreeCourses.FindAsync(id);

            if (degreeCourse == null)
            {
                return NotFound();
            }

            return degreeCourse;
        }

        // PUT: api/DegreeCourses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDegreeCourse(int id, DegreeCourse degreeCourse)
        {
            if (id != degreeCourse.DegreeCourseId)
            {
                return BadRequest();
            }

            _context.Entry(degreeCourse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DegreeCourseExists(id))
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

        // POST: api/DegreeCourses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DegreeCourse>> PostDegreeCourse(DegreeCourse degreeCourse)
        {
            _context.DegreeCourses.Add(degreeCourse);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDegreeCourse", new { id = degreeCourse.DegreeCourseId }, degreeCourse);
        }

        // DELETE: api/DegreeCourses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDegreeCourse(int id)
        {
            var degreeCourse = await _context.DegreeCourses.FindAsync(id);
            if (degreeCourse == null)
            {
                return NotFound();
            }

            _context.DegreeCourses.Remove(degreeCourse);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DegreeCourseExists(int id)
        {
            return _context.DegreeCourses.Any(e => e.DegreeCourseId == id);
        }
    }
}
