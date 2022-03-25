﻿#nullable disable

namespace HRSWebAPI.Controllers.PDS
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonalInformationsController : ControllerBase
    {
        private readonly HRISContext _context;

        public PersonalInformationsController(HRISContext context)
        {
            _context = context;
        }

        // GET: api/PersonalInformations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PersonalInformation>>> GetPersonalInformations()
        {
            return await _context.PersonalInformations.ToListAsync();
        }

        // GET: api/PersonalInformations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PersonalInformation>> GetPersonalInformation(int id)
        {
            var personalInformation = await _context.PersonalInformations.FindAsync(id);

            if (personalInformation == null)
            {
                return NotFound();
            }

            return personalInformation;
        }

        // PUT: api/PersonalInformations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonalInformation(int id, PersonalInformation personalInformation)
        {
            if (id != personalInformation.PersonId)
            {
                return BadRequest();
            }

            _context.Entry(personalInformation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonalInformationExists(id))
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

        // POST: api/PersonalInformations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PersonalInformation>> PostPersonalInformation(PersonalInformation personalInformation)
        {
            _context.PersonalInformations.Add(personalInformation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPersonalInformation", new { id = personalInformation.PersonId }, personalInformation);
        }

        // DELETE: api/PersonalInformations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonalInformation(int id)
        {
            var personalInformation = await _context.PersonalInformations.FindAsync(id);
            if (personalInformation == null)
            {
                return NotFound();
            }

            _context.PersonalInformations.Remove(personalInformation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PersonalInformationExists(int id)
        {
            return _context.PersonalInformations.Any(e => e.PersonId == id);
        }
    }
}
