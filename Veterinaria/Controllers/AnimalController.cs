using Microsoft.AspNetCore.Mvc;
using Veterinaria.Models;
using Veterinaria.Repository;

namespace Veterinaria.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class AnimalController : ControllerBase
    {
        private readonly IAnimalRepository _animalRepository;

        public AnimalController(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAnimals()
        {
            var animals = await _animalRepository.GetAllAnimals();
            return Ok(animals);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOneAnimal(int id)
        {
            var animal = await _animalRepository.GetAnimalById(id);
            if (animal != null)
            {
                return Ok(animal);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> PostAnimal(Animal animal)
        {
            await _animalRepository.AddAnimal(animal);
            return CreatedAtAction(nameof(GetOneAnimal), new { id = animal.Id }, animal);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAnimal(Animal animal, int id)
        {
            var animalToEdit = await _animalRepository.GetAnimalById(id);
            if (animalToEdit != null)
            {
                animalToEdit.Name = animal.Name;
                animalToEdit.OwnerName = animal.OwnerName;
                animalToEdit.BornDate = animal.BornDate;
                 await _animalRepository.UpdateAnimal(animalToEdit);
                
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAnimal(int id)
        {
            var animal =  await _animalRepository.GetAnimalById(id);
            if (animal != null)
            {
                await _animalRepository.DeleteAnimal(id);
                return NoContent();
            }
            return NotFound();
        }


    }
}
