using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CoreTwoZeroJS.Models;

namespace CoreTwoZeroJS.Controllers
{
    [Produces("application/json")]
    [Route("api/PersonTableCoreTwoJSApi")]
    public class PersonTableCoreTwoJSApiController : Controller
    {
        
        private readonly MydbContext _context;


        
        public PersonTableCoreTwoJSApiController(MydbContext context)
        {
            _context = context;
        }

        // GET: api/PersonTableCoreTwoJSApi
        [HttpGet]
        public IEnumerable<PersonTableCoreTwoJS> GetPersonTableCoreTwoJS()
        {
            return _context.PersonTableCoreTwoJS;
        }

        // GET: api/PersonTableCoreTwoJSApi/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPersonTableCoreTwoJS([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var personTableCoreTwoJS = await _context.PersonTableCoreTwoJS.SingleOrDefaultAsync(m => m.Id == id);

            if (personTableCoreTwoJS == null)
            {
                return NotFound();
            }

            return Ok(personTableCoreTwoJS);
        }

        // PUT: api/PersonTableCoreTwoJSApi/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPersonTableCoreTwoJS([FromRoute] int id, [FromBody] PersonTableCoreTwoJS personTableCoreTwoJS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != personTableCoreTwoJS.Id)
            {
                return BadRequest();
            }

            _context.Entry(personTableCoreTwoJS).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonTableCoreTwoJSExists(id))
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

        // POST: api/PersonTableCoreTwoJSApi
        [HttpPost]
        public async Task<IActionResult> PostPersonTableCoreTwoJS([FromBody] PersonTableCoreTwoJS personTableCoreTwoJS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.PersonTableCoreTwoJS.Add(personTableCoreTwoJS);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPersonTableCoreTwoJS", new { id = personTableCoreTwoJS.Id }, personTableCoreTwoJS);
        }

        // DELETE: api/PersonTableCoreTwoJSApi/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePersonTableCoreTwoJS([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var personTableCoreTwoJS = await _context.PersonTableCoreTwoJS.SingleOrDefaultAsync(m => m.Id == id);
            if (personTableCoreTwoJS == null)
            {
                return NotFound();
            }

            _context.PersonTableCoreTwoJS.Remove(personTableCoreTwoJS);
            await _context.SaveChangesAsync();

            return Ok(personTableCoreTwoJS);
        }

        private bool PersonTableCoreTwoJSExists(int id)
        {
            return _context.PersonTableCoreTwoJS.Any(e => e.Id == id);
        }
    }
}