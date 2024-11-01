using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPI.CQRS.MediatR.Data;
using WebAPI.CQRS.MediatR.Features.SuperHero.CreateSuperHeroes;
using WebAPI.CQRS.MediatR.Features.SuperHero.GetSuperHeroesById;
using WebAPI.CQRS.MediatR.Models;

namespace WebAPI.CQRS.MediatR.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroesController : ControllerBase
    {
        private readonly ISender _sender;

        public SuperHeroesController(ISender sender)
        {
            _sender = sender;
        }

        // GET: api/SuperHeroes
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<SuperHeroes>>> GetSuperHeroes()
        //{
        //    return await _context.SuperHeroes.ToListAsync();
        //}

        // GET: api/SuperHeroes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<SuperHeroes>> GetSuperHeroes(int id)
        {
            var player = await _sender.Send(new GetSuperHeroesByIdQuery(id));
            if (player is null) return NotFound();
            return Ok(player);
        }

        // POST: api/SuperHeroes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<SuperHeroes>> CreateSuperHeroes(CreateSuperHeroesCommand command)
        {
            var playerId = await _sender.Send(command);
            return Ok(playerId);
        }

        // PUT: api/SuperHeroes1/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutSuperHeroes(int id, SuperHeroes superHeroes)
        //{
        //    if (id != superHeroes.Id)
        //    {
        //        return BadRequest();
        //    }
        //    _context.Entry(superHeroes).State = EntityState.Modified;
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!SuperHeroesExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }
        //    return NoContent();
        //}

        // DELETE: api/SuperHeroes1/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteSuperHeroes(int id)
        //{
        //    var superHeroes = await _context.SuperHeroes.FindAsync(id);
        //    if (superHeroes == null)
        //    {
        //        return NotFound();
        //    }
        //    _context.SuperHeroes.Remove(superHeroes);
        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}

        //private bool SuperHeroesExists(int id)
        //{
        //    return _context.SuperHeroes.Any(e => e.Id == id);
        //}
    }
}
