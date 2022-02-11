using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HRSWebAPI.Data;
using HRSWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HRSWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BloodTypesController : ControllerBase
    {
        private readonly HRISContext _context;
        public BloodTypesController(HRISContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BloodType>>> GetBloodTypes()
        {
            return await _context.BloodTypes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<BloodType>> GetBloodType(int id)
        {
            var bloodtype = await _context.BloodTypes.FindAsync(id);

            if (bloodtype == null)
            {
                return NotFound();
            }
            return bloodtype;
        }

        [HttpPost]
        public async Task<ActionResult<BloodType>> PostBloodType(BloodType bloodtype)
        {
            _context.BloodTypes.Add(bloodtype);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (BloodTypeExists(bloodtype.BloodTypeId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }
            return CreatedAtAction("GetBloodType", new { id = bloodtype.BloodTypeId }, bloodtype);
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutBloodType(int id, BloodType bloodtype)
        {
            if (id != bloodtype.BloodTypeId)
            {
                return BadRequest();
            }
            _context.Entry(bloodtype).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!BloodTypeExists(id))
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

        private bool BloodTypeExists(int id)
        {
            return _context.BloodTypes.Any(e => e.BloodTypeId == id);
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBloodType(int id)
        {
            var bloodtype = await _context.BloodTypes.FindAsync(id);
            if (bloodtype == null)
            {
                return NotFound();
            }
            _context.BloodTypes.Remove(bloodtype);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
