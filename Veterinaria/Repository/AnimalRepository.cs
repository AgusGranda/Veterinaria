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
            return _dbContext.Animals.ToList();
        }

        public Animal GetAnimalById(int id)
        {
            return _dbContext.Animals.FirstOrDefault(x => x.Id == id);
        }


        public void AddAnimal(Animal animal)
        {
            _dbContext.Animals.Add(animal);
            _dbContext.SaveChanges();
        }

               
        public void UpdateAnimal(Animal animal)
        {
            _dbContext.Animals.Update(animal);
        }
        public void DeleteAnimal(int id)
        {
            var animal = _dbContext.Animals.FirstOrDefault(x => x.Id ==id);
            if (animal != null)
            {
                _dbContext.Animals.Remove(animal);
                _dbContext.SaveChanges();   
            }
        }

    }
}
