#nullable disable

namespace HRSWebAPI.Controllers.FM
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmploymentStatusController : ControllerBase
    {
        private readonly HRISContext _context;

        public EmploymentStatusController(HRISContext context)
        {
            _context = context;
        }

        // GET: api/EmploymentStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EmploymentStatus>>> GetEmploymentStatuses()
        {
            return await _context.EmploymentStatuses.ToListAsync();
        }

        // GET: api/EmploymentStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EmploymentStatus>> GetEmploymentStatus(int id)
        {
            var employmentStatus = await _context.EmploymentStatuses.FindAsync(id);

            if (employmentStatus == null)
            {
                return NotFound();
            }

            return employmentStatus;
        }

        // PUT: api/EmploymentStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmploymentStatus(int id, EmploymentStatus employmentStatus)
        {
            if (id != employmentStatus.EmploymentStatusId)
            {
                return BadRequest();
            }

            _context.Entry(employmentStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmploymentStatusExists(id))
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

        // POST: api/EmploymentStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<EmploymentStatus>> PostEmploymentStatus(EmploymentStatus employmentStatus)
        {
            _context.EmploymentStatuses.Add(employmentStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmploymentStatus", new { id = employmentStatus.EmploymentStatusId }, employmentStatus);
        }

        // DELETE: api/EmploymentStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmploymentStatus(int id)
        {
            var employmentStatus = await _context.EmploymentStatuses.FindAsync(id);
            if (employmentStatus == null)
            {
                return NotFound();
            }

            _context.EmploymentStatuses.Remove(employmentStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmploymentStatusExists(int id)
        {
            return _context.EmploymentStatuses.Any(e => e.EmploymentStatusId == id);
        }
    }
}
