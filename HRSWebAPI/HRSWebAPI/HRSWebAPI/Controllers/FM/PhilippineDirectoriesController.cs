#nullable disable

namespace HRSWebAPI.Controllers.FM
{
    [Route("api/[controller]")]
    [ApiController]
    public class PhilippineDirectoriesController : ControllerBase
    {
        private readonly HRISContext _context;

        public PhilippineDirectoriesController(HRISContext context)
        {
            _context = context;
        }

        // GET: api/PhilippineDirectories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PhilippineDirectory>>> GetPhilippineDirectories()
        {
            return await _context.PhilippineDirectories.ToListAsync();
        }

        // GET: api/PhilippineDirectories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PhilippineDirectory>> GetPhilippineDirectory(int id)
        {
            var philippineDirectory = await _context.PhilippineDirectories.FindAsync(id);

            if (philippineDirectory == null)
            {
                return NotFound();
            }

            return philippineDirectory;
        }

        // PUT: api/PhilippineDirectories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPhilippineDirectory(int id, PhilippineDirectory philippineDirectory)
        {
            if (id != philippineDirectory.Cmid)
            {
                return BadRequest();
            }

            _context.Entry(philippineDirectory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PhilippineDirectoryExists(id))
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

        // POST: api/PhilippineDirectories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PhilippineDirectory>> PostPhilippineDirectory(PhilippineDirectory philippineDirectory)
        {
            _context.PhilippineDirectories.Add(philippineDirectory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPhilippineDirectory", new { id = philippineDirectory.Cmid }, philippineDirectory);
        }

        // DELETE: api/PhilippineDirectories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePhilippineDirectory(int id)
        {
            var philippineDirectory = await _context.PhilippineDirectories.FindAsync(id);
            if (philippineDirectory == null)
            {
                return NotFound();
            }

            _context.PhilippineDirectories.Remove(philippineDirectory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PhilippineDirectoryExists(int id)
        {
            return _context.PhilippineDirectories.Any(e => e.Cmid == id);
        }
    }
}
