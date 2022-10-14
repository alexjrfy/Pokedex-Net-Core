using Business.Models;
using Data.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PokemonController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/<PokemonController>
        [HttpGet]
        public async Task<IEnumerable<Pokemon>> Get()
        {
            var pokemons = await _context.Pokemon
                .Include(t => t.Type1)
                .Include(t => t.Type2)
                .ToListAsync();
            return pokemons;
        }

        // GET api/<PokemonController>/5
        [HttpGet("{id}")]
        public async Task<Pokemon> Get(int id)
        {
            var pokemon = await _context.Pokemon.Where(x => x.NationalNumber  == id).FirstOrDefaultAsync();
            return pokemon;
        }
    }
}
