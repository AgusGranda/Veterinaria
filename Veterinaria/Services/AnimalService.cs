using Microsoft.AspNetCore.Mvc;
using Veterinaria.Models;
using Veterinaria.Repository;

namespace Veterinaria.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly IAnimalRepository _animalRepository;

        public AnimalService(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

      
        public async Task<IEnumerable<Animal>> GetAllAnimals()
        {
            return _animalRepository.GetAllAnimals();
            
        }

        public Task<IResult> GetAnimalById(int id)
        {
            //  return _animalRepository.GetAnimalById(id);
            throw new NotImplementedException();
        }

        public async Task AddAnimal(Animal animal)
        {
            _animalRepository.AddAnimal(animal);
            
        }

        public async Task UpdateAnimal(Animal animal, int id)
        {
            var animalToEdit = _animalRepository.GetAnimalById(id);
            if (animalToEdit != null)
            {
                animalToEdit.Name = animal.Name;
                animalToEdit.OwnerName = animal.OwnerName;
                animalToEdit.BornDate = animal.BornDate;
                _animalRepository.UpdateAnimal(animalToEdit);
            }
        }

        public async Task DeleteAnimal(int id)
        {
            var animal = _animalRepository.GetAnimalById(id);
            if (animal != null)
            {
                _animalRepository.DeleteAnimal(id);
            }
        }

        
    }
}
