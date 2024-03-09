using Veterinaria.Models;

namespace Veterinaria.Services
{
    public interface IAnimalService
    {
        Task<IEnumerable<Animal>> GetAllAnimals();
        Task<IResult> GetAnimalById(int id);
        Task AddAnimal(Animal animal);
        Task UpdateAnimal(Animal animal, int id);
        Task DeleteAnimal(int id);
    }
}
