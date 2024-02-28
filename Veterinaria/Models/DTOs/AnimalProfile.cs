using AutoMapper;

namespace Veterinaria.Models.DTOs
{
    public class AnimalProfile : Profile
    {
        public AnimalProfile() 
        {
            CreateMap<Animal, AnimalDTO>();
        }
    }
}
