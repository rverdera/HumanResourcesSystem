#nullable disable

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRSWebAPI.Controllers.FM
{
    [Route("api/[controller]")]
    [ApiController]
    public class LearningDevelopmentTypesController : ControllerBase
    {
        private readonly HRISContext _context;

        public LearningDevelopmentTypesController(HRISContext context)
        {
            _context = context;
        }

        // GET: api/LearningAndDevelopmentTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LearningAndDevelopmentType>>> LearningDevelopmentTypes()
        {
            return await _context.LearningAndDevelopmentTypes.ToListAsync();
        }

        // GET api/LearningAndDevelopmentTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LearningAndDevelopmentType>> GetLearningDevelopmentTypes(int id)
        {
            var learninganddevelopmenttype = await _context.LearningAndDevelopmentTypes.FindAsync(id);
            if (learninganddevelopmenttype == null)
            {
                return NotFound();
            }
            return learninganddevelopmenttype;
        }

        // POST api/LearningAndDevelopmentTypes
        [HttpPost]
        public async Task<ActionResult<LearningAndDevelopmentType>> PostLearningAndDevelopmentType(LearningAndDevelopmentType learningAndDevelopmentType)
        {
            _context.LearningAndDevelopmentTypes.Add(learningAndDevelopmentType);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLearningDevelopmentTypes", new { id = learningAndDevelopmentType.LearningAndDevelopmentTypeId }, learningAndDevelopmentType);

        }

        // PUT api/LearningAndDevelopmentTypes/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLearningAndDevelopmentTypes(int id, LearningAndDevelopmentType learningAndDevelopmenttypes)
        {
            if (id != learningAndDevelopmenttypes.LearningAndDevelopmentTypeId)
            {
                return BadRequest();
            }
            _context.Entry(learningAndDevelopmenttypes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                if (!LearningAndDevelopmentTypeExists(id))
                {
                    return NotFound();
                }
                throw;
            }
            return NoContent();
        }

        private bool LearningAndDevelopmentTypeExists(int id)
        {
            return _context.LearningAndDevelopmentTypes.Any(e => e.LearningAndDevelopmentTypeId == id);
        }

        // DELETE api/LearningAndDevelopmentTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLearningAndDevelopmentType(int id)
        {
            var learninganddevelopmenttype = await _context.LearningAndDevelopmentTypes.FindAsync(id);
            if (learninganddevelopmenttype == null)
            {
                return NotFound();
            }
            _context.LearningAndDevelopmentTypes.Remove(learninganddevelopmenttype);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
