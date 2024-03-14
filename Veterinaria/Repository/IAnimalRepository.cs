using Veterinaria.Models;

namespace Veterinaria.Repository
{
    public interface IAnimalRepository
    {
        Task<IEnumerable<Animal>> GetAllAnimals();
        Task<Animal> GetAnimalById(int id);
        Task AddAnimal(Animal animal);
        Task UpdateAnimal(Animal animal);
        Task DeleteAnimal(int id);
    }
}
