using Veterinaria.DataAccess;
using Veterinaria.Models;

namespace Veterinaria.Repository
{
    public class AnimalRepository : IAnimalRepository
    {
        private readonly MyDbContext _dbContext;

        public AnimalRepository(MyDbContext dbContext)
        {
            _dbContext = dbContext;
        }



        public IEnumerable<Animal> GetAllAnimals()
        {
            throw new NotImplementedException();
        }

        public Animal GetAnimalById(int id)
        {
            throw new NotImplementedException();
        }


        public void AddAnimal(Animal animal)
        {
            throw new NotImplementedException();
        }

               
        public void UpdateAnimal(Animal animal)
        {
            throw new NotImplementedException();
        }
        public void DeleteAnimal(int id)
        {
            throw new NotImplementedException();
        }

    }
}
