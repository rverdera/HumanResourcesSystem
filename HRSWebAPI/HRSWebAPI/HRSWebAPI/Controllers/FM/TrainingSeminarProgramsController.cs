#nullable disable

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRSWebAPI.Controllers.FM
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrainingSeminarProgramsController : ControllerBase
    {
        private  readonly HRISContext _context;
        public TrainingSeminarProgramsController(HRISContext context) 
        {
            _context = context;        
        }

        // GET: api/<TrainingSeminarProgramsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TrainingSeminarProgram>>> GetTrainingSeminarPrograms()
        {
            return await _context.TrainingSeminarPrograms.ToListAsync();
        }



        // GET api/<TrainingSeminarProgramsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TrainingSeminarProgram>> GetTrainingSeminarProgram(int id)
        {
            var trainingseminarprogram = await _context.TrainingSeminarPrograms.FindAsync(id);
            if (trainingseminarprogram == null)
            {
                return NotFound();
            }
            return trainingseminarprogram;
        }

        // POST api/<TrainingSeminarProgramsController>
        [HttpPost]
        public async Task<ActionResult<TrainingSeminarProgram>> PostTrainingSeminarProgram(TrainingSeminarProgram trainingSeminarProgram)
        {
            _context.TrainingSeminarPrograms.Add(trainingSeminarProgram);
            await _context.SaveChangesAsync();
            return CreatedAtAction("GetTrainingSeminarProgram", new { id = trainingSeminarProgram.TrainingSeminarProgramId }, trainingSeminarProgram);

        }

        // PUT api/<TrainingSeminarProgramsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrainingSeminarProgram(int id, TrainingSeminarProgram trainingSeminarProgram)
        {
            if (id != trainingSeminarProgram.TrainingSeminarProgramId)
            {
                return BadRequest();
            }
            
            _context.Entry(trainingSeminarProgram).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                if (!TrainingSeminarProgramExists(id))
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

        private bool TrainingSeminarProgramExists(int id)
        {
            return _context.TrainingSeminarPrograms.Any(e => e.TrainingSeminarProgramId == id);
        }

        // DELETE api/<TrainingSeminarProgramsController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteTrainingSeminarProgram(int id)
        {
            var trainingseminarprogram = await _context.TrainingSeminarPrograms.FindAsync(id);

            if (trainingseminarprogram != null) return NotFound();

            _context.TrainingSeminarPrograms.Remove(trainingseminarprogram);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
