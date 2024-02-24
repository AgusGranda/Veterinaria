using Microsoft.AspNetCore.Mvc;
using Veterinaria.Models;

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
        public IActionResult GetAllAnimals() 
        {
            var animalList = _animalRepository.GetAllAnimals();
            return Ok(animalList);
        }

        [HttpGet("{id}")]
        public IActionResult GetOneAnimal(int id)
        {
            var animal = _animalRepository.GetAnimalById(id);
            return Ok(animal);
        }

        [HttpPost]
        public IActionResult PostAnimal(Animal animal) 
        {
            _animalRepository.AddAnimal(animal);
            return CreatedAtAction(nameof(GetOneAnimal), new { id = animal.Id }, animal);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateAnimal(Animal animal , int id)
        {
            var animalToEdit = _animalRepository.GetAnimalById(id);
            if(animalToEdit != null)
            {
                animalToEdit.Name = animal.Name;
                animalToEdit.OwnerName = animal.OwnerName;
                animalToEdit.BornDate = animal.BornDate;
                _animalRepository.UpdateAnimal(animalToEdit);
                return NoContent();
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAnimal(int id)
        {
            var animal = _animalRepository.GetAnimalById(id);
            if (animal != null)
            {
                _animalRepository.DeleteAnimal(id);
                return NoContent(); 
            }
            return NotFound();
        }


    }
}
