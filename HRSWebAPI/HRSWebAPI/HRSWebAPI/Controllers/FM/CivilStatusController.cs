#nullable disable

namespace HRSWebAPI.Controllers.FM
{
    [Route("api/[controller]")]
    [ApiController]
    public class CivilStatusController : ControllerBase
    {
        private readonly HRISContext _context;

        public CivilStatusController(HRISContext context)
        {
            _context = context;
        }

        // GET: api/CivilStatus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CivilStatus>>> GetCivilStatuses()
        {
            return await _context.CivilStatuses.ToListAsync();
        }

        // GET: api/CivilStatus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CivilStatus>> GetCivilStatus(int id)
        {
            var civilStatus = await _context.CivilStatuses.FindAsync(id);

            if (civilStatus == null)
            {
                return NotFound();
            }

            return civilStatus;
        }

        // PUT: api/CivilStatus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCivilStatus(int id, CivilStatus civilStatus)
        {
            if (id != civilStatus.CivilStatusId)
            {
                return BadRequest();
            }

            _context.Entry(civilStatus).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CivilStatusExists(id))
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

        // POST: api/CivilStatus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CivilStatus>> PostCivilStatus(CivilStatus civilStatus)
        {
            _context.CivilStatuses.Add(civilStatus);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCivilStatus", new { id = civilStatus.CivilStatusId }, civilStatus);
        }

        // DELETE: api/CivilStatus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCivilStatus(int id)
        {
            var civilStatus = await _context.CivilStatuses.FindAsync(id);
            if (civilStatus == null)
            {
                return NotFound();
            }

            _context.CivilStatuses.Remove(civilStatus);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CivilStatusExists(int id)
        {
            return _context.CivilStatuses.Any(e => e.CivilStatusId == id);
        }
    }
}
