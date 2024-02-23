using System;

namespace Veterinaria.Models
{
    public class Animal
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OwnerName { get; set; }
        public DateTime Born { get; set; }
    }
}
