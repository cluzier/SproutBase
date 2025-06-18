using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlantTrackerApp.Server.Data;
using PlantTrackerApp.Server.Models;

namespace PlantTrackerApp.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlantsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PlantsController(AppDbContext context)
        {
            _context = context;
        }

        // Gets all plants.
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Plant>>> GetPlants()
        {
            return await _context.Plants.ToListAsync();
        }

        // Gets a plant by its ID.
        [HttpGet("{id}")]
        public async Task<ActionResult<Plant>> GetPlant(int id)
        {
            var plant = await _context.Plants.FindAsync(id);
            if (plant == null)
                return NotFound();
            return plant;
        }

        // Creates a new plant and adds it to the database.
        [HttpPost]
        public async Task<ActionResult<Plant>> PostPlant(Plant plant)
        {
            _context.Plants.Add(plant);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetPlant), new { id = plant.Id }, plant);
        }

        // Updates an existing plant by ID.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPlant(int id, Plant plant)
        {
            if (id != plant.Id)
                return BadRequest();

            _context.Entry(plant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Plants.Any(e => e.Id == id))
                    return NotFound();
                throw;
            }

            return NoContent();
        }

        // Deletes a plant by ID; 204 if deleted, 404 if not found
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePlant(int id)
        {
            var plant = await _context.Plants.FindAsync(id);
            if (plant == null)
                return NotFound();

            _context.Plants.Remove(plant);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
