﻿namespace Veterinaria.Models
{
    public interface IAnimalRepository
    {
        IEnumerable<Animal> GetAllAnimals();
        Animal GetAnimalById(int id);
        void AddAnimal(Animal animal);
        void UpdateAnimal(Animal animal);
        void DeleteAnimal(int id);  
    }
}