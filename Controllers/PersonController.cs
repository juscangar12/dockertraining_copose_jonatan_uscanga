using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dockertraining_copose_jonatan_uscanga.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace dockertraining_copose_jonatan_uscanga.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly PersonDbContext db;

        public PersonController(PersonDbContext context)
        {
            db = context;
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetPerson(int id)
        {
            var person = await db.Persons.FindAsync(id);
            if (person == default(Person))
            {
                return NotFound();
            }
            return Ok(person);
        }

        [HttpPost]
        public async Task<IActionResult> AddPerson([FromBody] Person person)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await db.AddAsync(person);
            await db.SaveChangesAsync();
            return Ok(person.Id);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeletePerson(int id)
        {
            var person = await db.Persons.FindAsync(id);
            if (person == default(Person))
            {
                return NotFound();
            }
            db.Persons.Remove(person);
            db.SaveChanges();
            return this. Ok("Person Deleted");
        }

    }
}
