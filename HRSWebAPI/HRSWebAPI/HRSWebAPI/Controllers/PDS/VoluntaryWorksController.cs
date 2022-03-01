#nullable disable

namespace HRSWebAPI.Controllers.PDS
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoluntaryWorksController : ControllerBase
    {
        private readonly HRISContext _context;

        public VoluntaryWorksController(HRISContext context)
        {
            _context = context;
        }

        // GET: api/VoluntaryWorks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VoluntaryWork>>> GetVoluntaryWorks()
        {
            return await _context.VoluntaryWorks.ToListAsync();
        }

        // GET: api/VoluntaryWorks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<VoluntaryWork>> GetVoluntaryWork(int id)
        {
            var voluntaryWork = await _context.VoluntaryWorks.FindAsync(id);

            if (voluntaryWork == null)
            {
                return NotFound();
            }

            return voluntaryWork;
        }

        // PUT: api/VoluntaryWorks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVoluntaryWork(int id, VoluntaryWork voluntaryWork)
        {
            if (id != voluntaryWork.RecordId)
            {
                return BadRequest();
            }

            _context.Entry(voluntaryWork).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VoluntaryWorkExists(id))
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

        // POST: api/VoluntaryWorks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<VoluntaryWork>> PostVoluntaryWork(VoluntaryWork voluntaryWork)
        {
            _context.VoluntaryWorks.Add(voluntaryWork);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVoluntaryWork", new { id = voluntaryWork.RecordId }, voluntaryWork);
        }

        // DELETE: api/VoluntaryWorks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVoluntaryWork(int id)
        {
            var voluntaryWork = await _context.VoluntaryWorks.FindAsync(id);
            if (voluntaryWork == null)
            {
                return NotFound();
            }

            _context.VoluntaryWorks.Remove(voluntaryWork);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool VoluntaryWorkExists(int id)
        {
            return _context.VoluntaryWorks.Any(e => e.RecordId == id);
        }
    }
}
