using Veterinaria.DataAccess;
using Veterinaria.Models;
using Microsoft.EntityFrameworkCore;

namespace Veterinaria.Repository
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly MyDbContext _dbContext;

        public AnimalRepository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Animal>> GetAllAnimals()
        {
            return await _dbContext.Animals.ToListAsync();
        }

        public async Task<Animal> GetAnimalById(int id)
        {
           return await _dbContext.Animals.FirstOrDefaultAsync(x => x.Id == id);
            
        }


        public async Task AddAnimal(Animal animal)
        {
            _dbContext.Animals.Add(animal);
            await _dbContext.SaveChangesAsync();
        }


        public async Task UpdateAnimal(Animal animal)
        {
            _dbContext.Animals.Update(animal);
            await _dbContext.SaveChangesAsync();
        }
        public async Task DeleteAnimal(int id)
        {
            var animal = _dbContext.Animals.FirstOrDefault(x => x.Id == id);
            if (animal != null)
            {
                _dbContext.Animals.Remove(animal);
                await _dbContext.SaveChangesAsync();
            }
        }

    }
}
